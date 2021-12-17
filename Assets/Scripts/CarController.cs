using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class CarController : MonoBehaviour
{
    [SerializeField] PathCreator pathCreator;
    [SerializeField] float _speed;
    float _distanceTravelled; 

    void Start()
    {
        
    }

    void Update()
    {
        _distanceTravelled += _speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(_distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(_distanceTravelled);
    }
}
