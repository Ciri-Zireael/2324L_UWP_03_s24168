using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5000f;
    private Rigidbody2D _rb;
    private Health _health;
    private Vector2 _movement;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _health = GetComponent<Health>();
        
        float moveHorizontal = Random.Range(-1f, 1f);
        float moveVertical = Random.Range(-1f, 1f);
        
        _movement = new Vector2(moveHorizontal, moveVertical).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = _movement * (_moveSpeed * Time.deltaTime);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Cat"))
        {
            _health.TakeDamage(1);
        }
    }
    
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
