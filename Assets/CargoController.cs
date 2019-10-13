using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargoController : MonoBehaviour
{
    public float speed = 15f;
    GameObject CargoShip;
    GameObject Planet;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        CargoShip = GameObject.FindWithTag("Cargo");
        Planet = GameObject.FindWithTag("PlanetOne");

        target = Planet.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float step =  speed * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

    }
}
