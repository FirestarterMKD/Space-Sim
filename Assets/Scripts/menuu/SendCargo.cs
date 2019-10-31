using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendCargo : MonoBehaviour
{
    GameObject CargoShip;
    GameObject Planet;
    GameObject PlanetTwo;
    GameObject PlanetThree;
    GameObject PlanetFour;
    GameObject PlanetFive;
    GameObject PlanetSix;
    GameObject PlanetSeven;

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

    private Transform target;
    private Transform position;
        
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
        
    }

    public void SendingCargo()
    {
        
            float step = speed * Time.deltaTime;
            CargoShip.transform.position = Vector3.MoveTowards(CargoShip.transform.position, target.position, step);
            Debug.Log("Cargo has been sent");
        
        
    }
}
