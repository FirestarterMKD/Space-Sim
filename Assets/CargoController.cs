using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargoController : MonoBehaviour
{
    public float speed = 15f;
    public float maxIron = 5000;
    public float maxUranium = 1000;
    public float cargoIron = 0;
    public float cargoUranium = 0;
    public float cargoFuel = 50;
    public float minFuel = 1;
    public float maxFuel = 1000;

    GameObject CargoShip;
    GameObject Planet;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        CargoShip = GameObject.FindWithTag("Cargo");
        Planet = GameObject.FindWithTag("PlanetOne");

        target = Planet.transform;
        cargoFuel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
            sendCargo();
    }
       
    void sendCargo()
    {

        if (cargoFuel > minFuel)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }


}
