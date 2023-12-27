using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpheresController : MonoBehaviour
{
    [SerializeField] private GameObject _root;
    [SerializeField] private DistanceCalculator _distanceCalculator;

    private void OnEnable()
    {
        _distanceCalculator.OnDistanceChange += ChangeState;
    }

    private void OnDisable()
    {
        _distanceCalculator.OnDistanceChange -= ChangeState;
    }
    void ChangeState(float distance)
    {
        if(distance < 1)
        {
            SceneManager.LoadScene("Scene2");
            return;
        }

        if(distance > 2)
            _root.SetActive(false);
        else
            _root.SetActive(true);
    }
}
