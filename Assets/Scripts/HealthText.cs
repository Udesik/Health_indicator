using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthText : HealthView
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void OnValueChanged(float current, float max)
    {
        _text.text = $"{current}/{max}";
    }
}
