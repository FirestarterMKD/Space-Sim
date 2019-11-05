using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargoController : MonoBehaviour
{

    public float playerIron = 0;
    public float playerUranium = 0;
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
    GameObject PlanetTwo;
    GameObject PlanetThree;
    GameObject PlanetFour;
    GameObject PlanetFive;
    GameObject PlanetSix;
    GameObject PlanetSeven;

    private Transform target;

    // Start is called before the first frame update
    void Start()

    {
        CargoShip = GameObject.FindWithTag("Cargo");
        Planet = GameObject.FindWithTag("PlanetOne");
        PlanetTwo = GameObject.FindWithTag("PlanetTwo");
        PlanetThree = GameObject.FindWithTag("PlanetThree");
        PlanetFour = GameObject.FindWithTag("PlanetFour");
        PlanetFive = GameObject.FindWithTag("PlanetFive");
        PlanetSix = GameObject.FindWithTag("PlanetSix");
        PlanetSeven = GameObject.FindWithTag("PlanetSeven");

        target = Planet.transform;


    }

    // Update is called once per frame
    void Update()
    {
        checkCargo();
        sendCargo();
        sendCargo2();
        sendCargo3();
        sendCargo4();
        sendCargo5();
        sendCargo6();
        sendCargo7();

    }

    public void sendCargo()
    {
        target = Planet.transform;
        
            if (cargoFuel > minFuel)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        
    }



    void sendCargo2()
    {
        target = PlanetTwo.transform;
        if (Input.GetKey("2"))
        {
            if (cargoFuel > minFuel)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        }
    }

    void sendCargo3()
    {
        target = PlanetThree.transform;
        if (Input.GetKey("3"))
        {
            if (cargoFuel > minFuel)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        }
    }

    void sendCargo4()
    {
        target = PlanetFour.transform;
        if (Input.GetKey("4"))
        {
            if (cargoFuel > minFuel)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        }
    }

    void sendCargo5()
    {
        target = PlanetFive.transform;
        if (Input.GetKey("5"))
        {
            if (cargoFuel > minFuel)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        }
    }

    void sendCargo6()
    {
        target = PlanetSix.transform;
        if (Input.GetKey("6"))
        {
            if (cargoFuel > minFuel)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        }
    }
    void sendCargo7()
    {
        target = PlanetSeven.transform;
        if (Input.GetKey("7"))
        {
            if (cargoFuel > minFuel)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        }
    }







    void checkCargo()
    {

        if (cargoIron > maxIron)
        {
            playerIron = cargoIron - maxIron;
            cargoIron = maxIron;
            print("That is too much Iron!!");
        }

        if (cargoUranium > maxUranium)
        {
            playerUranium = cargoUranium - maxUranium;
            cargoUranium = maxUranium;
            print("That is too much Uranium!!");


        }
    }

}


