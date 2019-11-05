using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCargo : MonoBehaviour
{
    public float speed = 15f;
    GameObject Planet;
    GameObject PlanetTwo;
    GameObject PlanetThree;
    GameObject PlanetFour;
    GameObject PlanetFive;
    GameObject PlanetSix;
    GameObject PlanetSeven;

    private Transform target;

    public bool CargoArrived;
    public bool CargoArrived2;
    public bool CargoArrived3;
    public bool CargoArrived4;
    public bool CargoArrived5;
    public bool CargoArrived6;

    // Start is called before the first frame update
    void Start()
    {
        Planet = GameObject.FindWithTag("PlanetOne");
        PlanetTwo = GameObject.FindWithTag("PlanetTwo");
        PlanetThree = GameObject.FindWithTag("PlanetThree");
        PlanetFour = GameObject.FindWithTag("PlanetFour");
        PlanetFive = GameObject.FindWithTag("PlanetFive");
        PlanetSix = GameObject.FindWithTag("PlanetSix");
        PlanetSeven = GameObject.FindWithTag("PlanetSeven");

        CargoArrived = true;
        CargoArrived2 = true;
        CargoArrived3 = true;
        CargoArrived4 = true;
        CargoArrived5 = true;
        CargoArrived6 = true;
    }

    void Update()
    {
        if (CargoArrived == false)
        {
            sendPlanet();
        }
        if (CargoArrived2 == false)
        {
            sendPlanet2();
        }
        if (CargoArrived3 == false)
        {
            sendPlanet3();
        }
        if (CargoArrived4 == false)
        {
            sendPlanet4();
        }
        if (CargoArrived5 == false)
        {
            sendPlanet5();
        }
    }

    void sendPlanet()
    {
        target = Planet.transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            CargoArrived = !CargoArrived;
        }

    }
    void sendPlanet2()
    {
        target = PlanetTwo.transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            CargoArrived2 = !CargoArrived2;
        }
    }
    void sendPlanet3()
    {
        target = PlanetThree.transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            CargoArrived3 = !CargoArrived3;
        }

    }
    void sendPlanet4()
    {
        target = PlanetFour.transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            CargoArrived4 = !CargoArrived4;
        }

    }
    void sendPlanet5()
    {
        target = PlanetFive.transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            CargoArrived5 = !CargoArrived5;
        }

    }

    public void SendingCargo()
    {
        CargoArrived = false;
    }

    public void SendCargoTwo()
    {
        CargoArrived2 = false;
    }

    public void SendCargoThree()
    {
        CargoArrived3 = false;
    }

    public void SendCargoFour()
    {
        CargoArrived4 = false;
    }

    public void SendCargoFive()
    {
        CargoArrived5 = false;
    }

}