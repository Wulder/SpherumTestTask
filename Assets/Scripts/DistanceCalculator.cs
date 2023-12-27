using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    public event Action<float> OnDistanceChange;

    [SerializeField] private Transform _target1, _target2;

    private float _prevDistance = 0;
    void Start()
    {
        
    }

   
    void Update()
    {
        float distance = Vector3.Distance(_target1.position, _target2.position);
        if(distance != _prevDistance) OnDistanceChange(distance);
    }
}
