using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int capacity;
    [SerializeField] private int _current;
    
    void Start()
    {
        _current = capacity;
    }

    public void TakeDamage(int amount)
    {
        _current -= amount;
        if (_current <= 0)
        {
            Die();
        }
    }

    public int GetCurrent()
    {
        return _current;
    }
    
    void Die()
    {
        Destroy(gameObject);
    }
}
