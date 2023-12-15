using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate()
    {
        var carPosition = car.transform.position;
        carPosition.z = -10;

        this.transform.position = carPosition;
    }
}
