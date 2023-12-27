using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private KeyCode _forward = KeyCode.W, _back = KeyCode.S, _right = KeyCode.D, _left = KeyCode.A;
   
    [SerializeField] private float _speed;

    
    void Update()
    {
        KeyInput();
    }

    void KeyInput()
    {
        Vector3 inputVector = Vector3.zero;
        if (Input.GetKey(_forward)) inputVector.z += 1;
        if (Input.GetKey(_back)) inputVector.z += -1;
        if (Input.GetKey(_right)) inputVector.x += 1;
        if (Input.GetKey(_left)) inputVector.x += -1;

        Move(inputVector.normalized);
    }

    void Move(Vector3 dir)
    {
        transform.Translate(dir * Time.deltaTime * _speed) ;
    }
}
