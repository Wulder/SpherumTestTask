using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private DistanceCalculator _calculator;
    private void OnEnable()
    {
        _calculator.OnDistanceChange += UpdateData;
    }

    private void OnDisable()
    {
        _calculator.OnDistanceChange -= UpdateData;
    }

    void UpdateData(float newValue)
    {
        _text.text = $"Distance {newValue.ToString("0.00")} meters";  
    }
}
