using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5000f;
    private Rigidbody2D _rb;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private Health _health;
        
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _health = GetComponent<Health>();
    }

    void Update()
    {
        Move();
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        _spriteRenderer.flipX = moveHorizontal < 0;
        
        Vector2 movement = new Vector2(moveHorizontal, moveVertical).normalized;
        _rb.velocity = movement * (_moveSpeed * Time.deltaTime);
        
        _animator.SetFloat("velocity", _rb.velocity.magnitude);
    }
    
    // TODO - actually implement xd
    void Attack()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Enemy"))
        {
            _health.TakeDamage(1);
        }
    }
}
