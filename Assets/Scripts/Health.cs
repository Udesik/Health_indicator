using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] private float _max = 100f;

    public event Action<float, float> Changed;
    
    private float _current;

    private void Awake()
    {
        _current = _max;
    }

    public void TakeDamage(float amount)
    {
        _current = Mathf.Clamp(_current - amount, 0, _max);
        Changed?.Invoke(_current, _max);
    }

    public void ApplyHeal(float amount)
    {
        _current = Mathf.Clamp(_current + amount, 0, _max);
        Changed?.Invoke(_current, _max);
    }
}
