using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCargo : MonoBehaviour
{
    public float speed = 500f;
    public GameObject Planet;
    public GameObject PlanetTwo;
    public GameObject PlanetThree;
    public GameObject PlanetFour;
    public GameObject PlanetFive;
    public GameObject PlanetSix;
    public GameObject PlanetSeven;
    public GameObject PlanetEight;
    public GameObject PlanetNine;
    public GameObject PlanetTen;

    public GameObject MyPlanet;


    private Transform target;

    public Transform targetHome;

    public bool CargoArrived;
    public bool CargoArrived2;
    public bool CargoArrived3;
    public bool CargoArrived4;
    public bool CargoArrived5;
    public bool CargoArrived6;
    public bool CargoArrived7;
    public bool CargoArrived8;
    public bool CargoArrived9;
    public bool CargoArrived10;

    public static int Capacity = 0;
    public static int CapacityUp = 2000;

    int Iron1;

    void Start()
    {
       /* Planet = GameObject.FindWithTag("PlanetOne");
        PlanetTwo = GameObject.FindWithTag("PlanetTwo");
        PlanetThree = GameObject.FindWithTag("PlanetThree");
        PlanetFour = GameObject.FindWithTag("PlanetFour");
        PlanetFive = GameObject.FindWithTag("PlanetFive");
        PlanetSix = GameObject.FindWithTag("PlanetSix");
        PlanetSeven = GameObject.FindWithTag("PlanetSeven");
        PlanetEight = GameObject.Find("ColliderGasGiantOne");
        PlanetNine = GameObject.Find("ColliderGasGiantTwo");
        PlanetTen = GameObject.Find("ColliderGasGiantThree"); */

        CargoArrived = true;
        CargoArrived2 = true;
        CargoArrived3 = true;
        CargoArrived4 = true;
        CargoArrived5 = true;
        CargoArrived6 = true;
        CargoArrived7 = true;
        CargoArrived8 = true;
        CargoArrived9 = true;
        CargoArrived10 = true;


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
        if (CargoArrived6 == false)
        {
            sendPlanet6();
        }
        if (CargoArrived7 == false)
        {
            sendPlanet7();
        }
        if (CargoArrived8 == false)
        {
            sendPlanet8();
        }
        if (CargoArrived9 == false)
        {
            sendPlanet9();
        }
        if (CargoArrived10 == false)
        {
            sendPlanet10();
        }

        if (CargoArrived == true & CargoArrived2 == true & CargoArrived3 == true & CargoArrived4 == true & CargoArrived5 == true & CargoArrived6 == true & CargoArrived7 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetHome.position, 50f *  Time.deltaTime);
        }

    }

    void sendPlanet()
    {
        target = Planet.transform;
        float step = speed * Time.deltaTime;

        if (CargoArrived == false)
        {
            if (Capacity > 0)
            {
                Debug.Log(Capacity);
                if (PlayerPlanetScript.fuel >= 10)
                {
                    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                    if (Vector3.Distance(transform.position, target.position) < 0.001f)
                    {
                        if (Planet.GetComponent<RandomResources>().randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + Planet.GetComponent<RandomResources>().randomIron;
                            Planet.GetComponent<RandomResources>().randomIron = Planet.GetComponent<RandomResources>().randomIron - Planet.GetComponent<RandomResources>().randomIron;
                            Capacity -= Planet.GetComponent<RandomResources>().randomIron;

                            if (Capacity > Planet.GetComponent<RandomResources>().randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + Planet.GetComponent<RandomResources>().randomRawFuel;
                                Planet.GetComponent<RandomResources>().randomRawFuel = Planet.GetComponent<RandomResources>().randomRawFuel - Planet.GetComponent<RandomResources>().randomRawFuel;
                                Capacity -= Planet.GetComponent<RandomResources>().randomRawFuel;

                                if (Capacity > Planet.GetComponent<RandomResources>().randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Planet.GetComponent<RandomResources>().randomUranium;
                                    Planet.GetComponent<RandomResources>().randomUranium = Planet.GetComponent<RandomResources>().randomUranium - Planet.GetComponent<RandomResources>().randomUranium;
                                    Capacity -= Planet.GetComponent<RandomResources>().randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    Planet.GetComponent<RandomResources>().randomUranium = Planet.GetComponent<RandomResources>().randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + Capacity;
                                Planet.GetComponent<RandomResources>().randomRawFuel = Planet.GetComponent<RandomResources>().randomRawFuel - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                            Planet.GetComponent<RandomResources>().randomIron = Planet.GetComponent<RandomResources>().randomIron - Capacity;
                            Capacity -= Capacity;
                        }

                        CargoArrived = true;
                        Capacity = CapacityUp;
                    }
                }
                else
                {
                    Debug.Log("Not enough fuel(10 for every trip)");
                }
            }
        }

    }
    void sendPlanet2()
    {
        target = PlanetTwo.transform;
        float step = speed * Time.deltaTime;

        if (CargoArrived2 == false)
        {
            if (Capacity > 0)
            {

                Debug.Log(Capacity);
                if (PlayerPlanetScript.fuel >= 10)
                {
                    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                    if (Vector3.Distance(transform.position, target.position) < 0.001f)
                    {
                        if (PlanetTwo.GetComponent<RandomResources>().randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + PlanetTwo.GetComponent<RandomResources>().randomIron;
                            PlanetTwo.GetComponent<RandomResources>().randomIron = PlanetTwo.GetComponent<RandomResources>().randomIron - PlanetTwo.GetComponent<RandomResources>().randomIron;
                            Capacity -= PlanetTwo.GetComponent<RandomResources>().randomIron;

                            if (Capacity > PlanetTwo.GetComponent<RandomResources>().randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + PlanetTwo.GetComponent<RandomResources>().randomRawFuel;
                                PlanetTwo.GetComponent<RandomResources>().randomRawFuel = PlanetTwo.GetComponent<RandomResources>().randomRawFuel - PlanetTwo.GetComponent<RandomResources>().randomRawFuel;
                                Capacity -= PlanetTwo.GetComponent<RandomResources>().randomRawFuel;

                                if (Capacity > PlanetTwo.GetComponent<RandomResources>().randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + PlanetTwo.GetComponent<RandomResources>().randomUranium;
                                    PlanetTwo.GetComponent<RandomResources>().randomUranium = PlanetTwo.GetComponent<RandomResources>().randomUranium - PlanetTwo.GetComponent<RandomResources>().randomUranium;
                                    Capacity -= PlanetTwo.GetComponent<RandomResources>().randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    PlanetTwo.GetComponent<RandomResources>().randomUranium = PlanetTwo.GetComponent<RandomResources>().randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + Capacity;
                                PlanetTwo.GetComponent<RandomResources>().randomRawFuel = PlanetTwo.GetComponent<RandomResources>().randomRawFuel - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                            PlanetTwo.GetComponent<RandomResources>().randomIron = PlanetTwo.GetComponent<RandomResources>().randomIron - Capacity;
                            Capacity -= Capacity;
                        }

                        CargoArrived2 = true;
                        Capacity = CapacityUp;
                    }
                }
                else
                {
                    Debug.Log("Not enough fuel(10 for every trip)");
                }
            }
        }
    }
    void sendPlanet3()
    {
        target = PlanetThree.transform;
        float step = speed * Time.deltaTime;

        if (CargoArrived3 == false)
        {
            if (Capacity > 0)
            {
                if (PlayerPlanetScript.fuel >= 10)
                {
                    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                    if (Vector3.Distance(transform.position, target.position) < 0.001f)
                    {
                        if (PlanetThree.GetComponent<RandomResources>().randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + PlanetThree.GetComponent<RandomResources>().randomIron;
                            PlanetThree.GetComponent<RandomResources>().randomIron = PlanetThree.GetComponent<RandomResources>().randomIron - PlanetThree.GetComponent<RandomResources>().randomIron;
                            Capacity -= PlanetThree.GetComponent<RandomResources>().randomIron;

                            if (Capacity > PlanetThree.GetComponent<RandomResources>().randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + PlanetThree.GetComponent<RandomResources>().randomRawFuel;
                                PlanetThree.GetComponent<RandomResources>().randomRawFuel = PlanetThree.GetComponent<RandomResources>().randomRawFuel - PlanetThree.GetComponent<RandomResources>().randomRawFuel;
                                Capacity -= PlanetThree.GetComponent<RandomResources>().randomRawFuel;

                                if (Capacity > PlanetThree.GetComponent<RandomResources>().randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + PlanetThree.GetComponent<RandomResources>().randomUranium;
                                    PlanetThree.GetComponent<RandomResources>().randomUranium = PlanetThree.GetComponent<RandomResources>().randomUranium - PlanetThree.GetComponent<RandomResources>().randomUranium;
                                    Capacity -= PlanetThree.GetComponent<RandomResources>().randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    PlanetThree.GetComponent<RandomResources>().randomUranium = PlanetThree.GetComponent<RandomResources>().randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + Capacity;
                                PlanetThree.GetComponent<RandomResources>().randomRawFuel = PlanetThree.GetComponent<RandomResources>().randomRawFuel - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                            PlanetThree.GetComponent<RandomResources>().randomIron = PlanetThree.GetComponent<RandomResources>().randomIron - Capacity;
                            Capacity -= Capacity;
                        }

                        CargoArrived3 = true;
                        Capacity = CapacityUp;
                    }
                }
                else
                {
                    Debug.Log("Not enough fuel(10 for every trip)");
                }
            }
        }

    }
    void sendPlanet4()
    {
        target = PlanetFour.transform;
        float step = speed * Time.deltaTime;

        if (CargoArrived4 == false)
        {
            if (Capacity > 0)
            {
                if (PlayerPlanetScript.fuel >= 10)
                {
                    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                    if (Vector3.Distance(transform.position, target.position) < 0.001f)
                    {
                        if (PlanetFour.GetComponent<RandomResources>().randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + PlanetFour.GetComponent<RandomResources>().randomIron;
                            PlanetFour.GetComponent<RandomResources>().randomIron = PlanetFour.GetComponent<RandomResources>().randomIron - PlanetFour.GetComponent<RandomResources>().randomIron;
                            Capacity -= PlanetFour.GetComponent<RandomResources>().randomIron;

                            if (Capacity > PlanetFour.GetComponent<RandomResources>().randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + PlanetFour.GetComponent<RandomResources>().randomRawFuel;
                                PlanetFour.GetComponent<RandomResources>().randomRawFuel = PlanetFour.GetComponent<RandomResources>().randomRawFuel - PlanetFour.GetComponent<RandomResources>().randomRawFuel;
                                Capacity -= PlanetFour.GetComponent<RandomResources>().randomRawFuel;

                                if (Capacity > PlanetFour.GetComponent<RandomResources>().randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + PlanetFour.GetComponent<RandomResources>().randomUranium;
                                    PlanetFour.GetComponent<RandomResources>().randomUranium = PlanetFour.GetComponent<RandomResources>().randomUranium - PlanetFour.GetComponent<RandomResources>().randomUranium;
                                    Capacity -= PlanetFour.GetComponent<RandomResources>().randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    PlanetFour.GetComponent<RandomResources>().randomUranium = PlanetFour.GetComponent<RandomResources>().randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + Capacity;
                                PlanetFour.GetComponent<RandomResources>().randomRawFuel = PlanetFour.GetComponent<RandomResources>().randomRawFuel - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                            PlanetFour.GetComponent<RandomResources>().randomIron = PlanetFour.GetComponent<RandomResources>().randomIron - Capacity;
                            Capacity -= Capacity;
                        }

                        CargoArrived4 = true;
                        Capacity = CapacityUp;
                    }
                }
                else
                {
                    Debug.Log("Not enough fuel(10 for every trip)");
                }
            }
        }

    }
    void sendPlanet5()
    {
        target = PlanetFive.transform;
        float step = speed * Time.deltaTime;

        if (CargoArrived5 == false)
        {
            if (Capacity > 0)
            {
                if (PlayerPlanetScript.fuel >= 10)
                {
                    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                    if (Vector3.Distance(transform.position, target.position) < 0.001f)
                    {
                        if (PlanetFive.GetComponent<RandomResources>().randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + PlanetFive.GetComponent<RandomResources>().randomIron;
                            PlanetFive.GetComponent<RandomResources>().randomIron = PlanetFive.GetComponent<RandomResources>().randomIron - PlanetFive.GetComponent<RandomResources>().randomIron;
                            Capacity -= PlanetFive.GetComponent<RandomResources>().randomIron;

                            if (Capacity > PlanetFive.GetComponent<RandomResources>().randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + PlanetFive.GetComponent<RandomResources>().randomRawFuel;
                                PlanetFive.GetComponent<RandomResources>().randomRawFuel = PlanetFive.GetComponent<RandomResources>().randomRawFuel - PlanetFive.GetComponent<RandomResources>().randomRawFuel;
                                Capacity -= PlanetFive.GetComponent<RandomResources>().randomRawFuel;

                                if (Capacity > PlanetFive.GetComponent<RandomResources>().randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + PlanetFive.GetComponent<RandomResources>().randomUranium;
                                    PlanetFive.GetComponent<RandomResources>().randomUranium = PlanetFive.GetComponent<RandomResources>().randomUranium - PlanetFive.GetComponent<RandomResources>().randomUranium;
                                    Capacity -= PlanetFive.GetComponent<RandomResources>().randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    PlanetFive.GetComponent<RandomResources>().randomUranium = PlanetFive.GetComponent<RandomResources>().randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + Capacity;
                                PlanetFive.GetComponent<RandomResources>().randomRawFuel = PlanetFive.GetComponent<RandomResources>().randomRawFuel - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                            PlanetFive.GetComponent<RandomResources>().randomIron = PlanetFive.GetComponent<RandomResources>().randomIron - Capacity;
                            Capacity -= Capacity;
                        }

                        CargoArrived5 = true;
                        Capacity = CapacityUp;
                    }
                }
                else
                {
                    Debug.Log("Not enough fuel(10 for every trip)");
                }
            }
        }

    }
    void sendPlanet6()
    {
        target = PlanetSix.transform;
        float step = speed * Time.deltaTime;

        if (CargoArrived6 == false)
        {
            if (Capacity > 0)
            {
                if (PlayerPlanetScript.fuel >= 10)
                {
                    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                    if (Vector3.Distance(transform.position, target.position) < 0.001f)
                    {
                        if (PlanetSix.GetComponent<RandomResources>().randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + PlanetSix.GetComponent<RandomResources>().randomIron;
                            PlanetSix.GetComponent<RandomResources>().randomIron = PlanetSix.GetComponent<RandomResources>().randomIron - PlanetSix.GetComponent<RandomResources>().randomIron;
                            Capacity -= PlanetSix.GetComponent<RandomResources>().randomIron;

                            if (Capacity > PlanetSix.GetComponent<RandomResources>().randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + PlanetSix.GetComponent<RandomResources>().randomRawFuel;
                                PlanetSix.GetComponent<RandomResources>().randomRawFuel = PlanetSix.GetComponent<RandomResources>().randomRawFuel - PlanetSix.GetComponent<RandomResources>().randomRawFuel;
                                Capacity -= PlanetSix.GetComponent<RandomResources>().randomRawFuel;

                                if (Capacity > PlanetSix.GetComponent<RandomResources>().randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + PlanetSix.GetComponent<RandomResources>().randomUranium;
                                    PlanetSix.GetComponent<RandomResources>().randomUranium = PlanetSix.GetComponent<RandomResources>().randomUranium - PlanetSix.GetComponent<RandomResources>().randomUranium;
                                    Capacity -= PlanetSix.GetComponent<RandomResources>().randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    PlanetSix.GetComponent<RandomResources>().randomUranium = PlanetSix.GetComponent<RandomResources>().randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + Capacity;
                                PlanetSix.GetComponent<RandomResources>().randomRawFuel = PlanetSix.GetComponent<RandomResources>().randomRawFuel - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                            PlanetSix.GetComponent<RandomResources>().randomIron = PlanetSix.GetComponent<RandomResources>().randomIron - Capacity;
                            Capacity -= Capacity;
                        }

                        CargoArrived6 = true;
                        Capacity = CapacityUp;
                    }
                }
                else
                {
                    Debug.Log("Not enough fuel(10 for every trip)");
                }
            }
        }

    }
    void sendPlanet7()
    {
        target = PlanetSeven.transform;
        float step = speed * Time.deltaTime;

        if (CargoArrived7 == false)
        {
            if (Capacity > 0)
            {
                if (PlayerPlanetScript.fuel >= 10)
                {
                    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                    if (Vector3.Distance(transform.position, target.position) < 0.001f)
                    {
                        if (PlanetSeven.GetComponent<RandomResources>().randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + PlanetSeven.GetComponent<RandomResources>().randomIron;
                            PlanetSeven.GetComponent<RandomResources>().randomIron = PlanetSeven.GetComponent<RandomResources>().randomIron - PlanetSeven.GetComponent<RandomResources>().randomIron;
                            Capacity -= PlanetSeven.GetComponent<RandomResources>().randomIron;

                            if (Capacity > PlanetSeven.GetComponent<RandomResources>().randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + PlanetSeven.GetComponent<RandomResources>().randomRawFuel;
                                PlanetSeven.GetComponent<RandomResources>().randomRawFuel = PlanetSeven.GetComponent<RandomResources>().randomRawFuel - PlanetSeven.GetComponent<RandomResources>().randomRawFuel;
                                Capacity -= PlanetSeven.GetComponent<RandomResources>().randomRawFuel;

                                if (Capacity > PlanetSeven.GetComponent<RandomResources>().randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + PlanetSeven.GetComponent<RandomResources>().randomUranium;
                                    PlanetSeven.GetComponent<RandomResources>().randomUranium = PlanetSeven.GetComponent<RandomResources>().randomUranium - PlanetSeven.GetComponent<RandomResources>().randomUranium;
                                    Capacity -= PlanetSeven.GetComponent<RandomResources>().randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    PlanetSeven.GetComponent<RandomResources>().randomUranium = PlanetSeven.GetComponent<RandomResources>().randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + Capacity;
                                PlanetSeven.GetComponent<RandomResources>().randomRawFuel = PlanetSeven.GetComponent<RandomResources>().randomRawFuel - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                            PlanetSeven.GetComponent<RandomResources>().randomIron = PlanetSeven.GetComponent<RandomResources>().randomIron - Capacity;
                            Capacity -= Capacity;
                        }

                        CargoArrived7 = true;
                        Capacity = CapacityUp;
                    }
                }
                else
                {
                    Debug.Log("Not enough fuel(10 for every trip)");
                }
            }
        }

    }
    void sendPlanet8()
    {
        target = PlanetEight.transform;
        float step = speed * Time.deltaTime;

        if (CargoArrived8 == false)
        {

            if (PlayerPlanetScript.fuel >= 10)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                if (Vector3.Distance(transform.position, target.position) < 0.001f)
                {
                    PlayerPlanetScript.iron = PlayerPlanetScript.iron + 500;
                    CargoArrived8 = true;
                }
            }
            else
            {
                Debug.Log("Not enough fuel(10 for every trip)");
            }
        }

    }
    void sendPlanet9()
    {
        target = PlanetNine.transform;
        float step = speed * Time.deltaTime;

        if (CargoArrived9 == false)
        {

            if (PlayerPlanetScript.fuel >= 10)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                if (Vector3.Distance(transform.position, target.position) < 0.001f)
                {
                    PlayerPlanetScript.iron = PlayerPlanetScript.iron + 500;
                    CargoArrived9 = true;
                }
            }
            else
            {
                Debug.Log("Not enough fuel(10 for every trip)");
            }
        }

    }
    void sendPlanet10()
    {
        target = PlanetTen.transform;
        float step = speed * Time.deltaTime;
        if (PlayerPlanetScript.fuel >= 10)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                PlayerPlanetScript.iron = PlayerPlanetScript.iron + 500;
                CargoArrived = !CargoArrived;
            }
        }
        else
        {
            Debug.Log("Not enough fuel(10 for every trip)");
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
    public void SendCargoSix()
    {
        CargoArrived6 = false;
    }
    public void SendCargoSeven()
    {
        CargoArrived7 = false;
    }
    public void SendCargoEight()
    {
        CargoArrived8 = false;
    }
    public void SendCargoNine()
    {
        CargoArrived9 = false;
    }
    public void SendCargoTen()
    {
        CargoArrived10 = false;
    }
}