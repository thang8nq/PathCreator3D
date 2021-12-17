using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class CarController : MonoBehaviour
{
    [SerializeField] PathCreator pathCreator;
    [SerializeField] EndOfPathInstruction destination;
    [SerializeField] float _speed;
    float _distanceTravelled; 

    void Start()
    {
        Debug.Log("start pos: " + pathCreator.path.GetPoint(0));
        Debug.Log("end pos: " + pathCreator.path.GetPoint(1));
        Debug.Log("rad pos: " + pathCreator.path.GetPoint(3));
    }

    void Update()
    {
        _distanceTravelled += _speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(_distanceTravelled, destination);
        transform.rotation = pathCreator.path.GetRotationAtDistance(_distanceTravelled, destination);
    }


}
