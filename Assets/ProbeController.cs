using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeController : MonoBehaviour

{
    public float speed = 15f;
    GameObject CargoShip;
    GameObject ColliderPlanet7;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        CargoShip = GameObject.FindWithTag("Cargo");
        ColliderPlanet7 = GameObject.FindWithTag("PlanetSeven");

        target = ColliderPlanet7.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

    }


}

