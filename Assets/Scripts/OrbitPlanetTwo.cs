using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitPlanetTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float rotationSpeed = 1.5f;
    void Update()
    {
         transform.Rotate(0,rotationSpeed*Time.deltaTime,0);
    }
}
