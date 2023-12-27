using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyLooker : MonoBehaviour
{
    [SerializeField] private Transform _body, _target;


    void Update()
    {
        _body.LookAt(_target);
    }
}
