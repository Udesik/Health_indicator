using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class ActionButton : MonoBehaviour
{
    [SerializeField] protected float Amount = 10f;
    [SerializeField] protected Health Health;
    
    private Button _button;

    private void Awake() => _button = GetComponent<Button>();

    private void OnEnable() => _button.onClick.AddListener(PerformAction);

    private void OnDisable() => _button.onClick.RemoveListener(PerformAction);

    protected abstract void PerformAction();
}
