using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCargo : MonoBehaviour
{
    public float speed = 500f;
    public GameObject Planet;
    GameObject PlanetTwo;
    GameObject PlanetThree;
    GameObject PlanetFour;
    GameObject PlanetFive;
    GameObject PlanetSix;
    GameObject PlanetSeven;
    GameObject PlanetEight;
    GameObject PlanetNine;
    GameObject PlanetTen;

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

    public static int Capacity = 3000;

    int Iron1;
    void Start()
    {
        Planet = GameObject.FindWithTag("PlanetOne");
        PlanetTwo = GameObject.FindWithTag("PlanetTwo");
        PlanetThree = GameObject.FindWithTag("PlanetThree");
        PlanetFour = GameObject.FindWithTag("PlanetFour");
        PlanetFive = GameObject.FindWithTag("PlanetFive");
        PlanetSix = GameObject.FindWithTag("PlanetSix");
        PlanetSeven = GameObject.FindWithTag("PlanetSeven");
        PlanetEight = GameObject.Find("ColliderGasGiantOne");
        PlanetNine = GameObject.Find("ColliderGasGiantTwo");
        PlanetTen = GameObject.Find("ColliderGasGiantThree");

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
            transform.position = Vector3.MoveTowards(transform.position, targetHome.position, 250f *  Time.deltaTime);
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
                if (PlayerPlanetScript.fuel >= 10)
                {
                    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                    if (Vector3.Distance(transform.position, target.position) < 0.001f)
                    {
                        if (RandomResources.randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + RandomResources.randomIron;
                            RandomResources.randomIron = RandomResources.randomIron - RandomResources.randomIron;
                            Capacity -= RandomResources.randomIron;

                            if (Capacity > RandomResources.randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + RandomResources.randomRawFuel;
                                RandomResources.randomRawFuel = RandomResources.randomRawFuel - RandomResources.randomRawFuel;
                                Capacity -= RandomResources.randomRawFuel;

                                if (Capacity > RandomResources.randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + RandomResources.randomUranium;
                                    RandomResources.randomUranium = RandomResources.randomUranium - RandomResources.randomUranium;
                                    Capacity -= RandomResources.randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    RandomResources.randomUranium = RandomResources.randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                                RandomResources.randomIron = RandomResources.randomIron - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + 3000;
                            RandomResources.randomIron = RandomResources.randomIron - 3000;
                            Capacity -= Capacity;
                        }

                        CargoArrived = true;
                        Capacity = 3000;
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
                if (PlayerPlanetScript.fuel >= 10)
                {
                    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                    if (Vector3.Distance(transform.position, target.position) < 0.001f)
                    {
                        if (RandomResources.randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + RandomResources.randomIron;
                            RandomResources.randomIron = RandomResources.randomIron - RandomResources.randomIron;
                            Capacity -= RandomResources.randomIron;

                            if (Capacity > RandomResources.randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + RandomResources.randomRawFuel;
                                RandomResources.randomRawFuel = RandomResources.randomRawFuel - RandomResources.randomRawFuel;
                                Capacity -= RandomResources.randomRawFuel;

                                if (Capacity > RandomResources.randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + RandomResources.randomUranium;
                                    RandomResources.randomUranium = RandomResources.randomUranium - RandomResources.randomUranium;
                                    Capacity -= RandomResources.randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    RandomResources.randomUranium = RandomResources.randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                                RandomResources.randomIron = RandomResources.randomIron - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + 3000;
                            RandomResources.randomIron = RandomResources.randomIron - 3000;
                            Capacity -= Capacity;
                        }
                        CargoArrived2 = true;

                        Capacity = 3000;
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
                        if (RandomResources.randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + RandomResources.randomIron;
                            RandomResources.randomIron = RandomResources.randomIron - RandomResources.randomIron;
                            Capacity -= RandomResources.randomIron;

                            if (Capacity > RandomResources.randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + RandomResources.randomRawFuel;
                                RandomResources.randomRawFuel = RandomResources.randomRawFuel - RandomResources.randomRawFuel;
                                Capacity -= RandomResources.randomRawFuel;

                                if (Capacity > RandomResources.randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + RandomResources.randomUranium;
                                    RandomResources.randomUranium = RandomResources.randomUranium - RandomResources.randomUranium;
                                    Capacity -= RandomResources.randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    RandomResources.randomUranium = RandomResources.randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                                RandomResources.randomIron = RandomResources.randomIron - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + 3000;
                            RandomResources.randomIron = RandomResources.randomIron - 3000;
                            Capacity -= Capacity;
                        }

                        CargoArrived3 = true;
                        Capacity = 3000;
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
                        if (RandomResources.randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + RandomResources.randomIron;
                            RandomResources.randomIron = RandomResources.randomIron - RandomResources.randomIron;
                            Capacity -= RandomResources.randomIron;

                            if (Capacity > RandomResources.randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + RandomResources.randomRawFuel;
                                RandomResources.randomRawFuel = RandomResources.randomRawFuel - RandomResources.randomRawFuel;
                                Capacity -= RandomResources.randomRawFuel;

                                if (Capacity > RandomResources.randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + RandomResources.randomUranium;
                                    RandomResources.randomUranium = RandomResources.randomUranium - RandomResources.randomUranium;
                                    Capacity -= RandomResources.randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    RandomResources.randomUranium = RandomResources.randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                                RandomResources.randomRawFuel = RandomResources.randomRawFuel - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + 3000;
                            RandomResources.randomIron = RandomResources.randomIron - 3000;
                            Capacity -= Capacity;
                        }

                        CargoArrived4 = true;
                        Capacity = 3000;
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
                        if (RandomResources.randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + RandomResources.randomIron;
                            RandomResources.randomIron = RandomResources.randomIron - RandomResources.randomIron;
                            Capacity -= RandomResources.randomIron;

                            if (Capacity > RandomResources.randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + RandomResources.randomRawFuel;
                                RandomResources.randomRawFuel = RandomResources.randomRawFuel - RandomResources.randomRawFuel;
                                Capacity -= RandomResources.randomRawFuel;

                                if (Capacity > RandomResources.randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + RandomResources.randomUranium;
                                    RandomResources.randomUranium = RandomResources.randomUranium - RandomResources.randomUranium;
                                    Capacity -= RandomResources.randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    RandomResources.randomUranium = RandomResources.randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                                RandomResources.randomIron = RandomResources.randomIron - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + 3000;
                            RandomResources.randomIron = RandomResources.randomIron - 3000;
                            Capacity -= Capacity;
                        }

                        CargoArrived5 = true;
                        Capacity = 3000;
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
                        if (RandomResources.randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + RandomResources.randomIron;
                            RandomResources.randomIron = RandomResources.randomIron - RandomResources.randomIron;
                            Capacity -= RandomResources.randomIron;

                            if (Capacity > RandomResources.randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + RandomResources.randomRawFuel;
                                RandomResources.randomRawFuel = RandomResources.randomRawFuel - RandomResources.randomRawFuel;
                                Capacity -= RandomResources.randomRawFuel;

                                if (Capacity > RandomResources.randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + RandomResources.randomUranium;
                                    RandomResources.randomUranium = RandomResources.randomUranium - RandomResources.randomUranium;
                                    Capacity -= RandomResources.randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    RandomResources.randomUranium = RandomResources.randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                                RandomResources.randomIron = RandomResources.randomIron - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + 3000;
                            RandomResources.randomIron = RandomResources.randomIron - 3000;
                            Capacity -= Capacity;
                        }

                        CargoArrived6 = true;
                        Capacity = 3000;
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
                        if (RandomResources.randomIron < Capacity)
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + RandomResources.randomIron;
                            RandomResources.randomIron = RandomResources.randomIron - RandomResources.randomIron;
                            Capacity -= RandomResources.randomIron;

                            if (Capacity > RandomResources.randomRawFuel)
                            {
                                PlayerPlanetScript.fuel = PlayerPlanetScript.fuel + RandomResources.randomRawFuel;
                                RandomResources.randomRawFuel = RandomResources.randomRawFuel - RandomResources.randomRawFuel;
                                Capacity -= RandomResources.randomRawFuel;

                                if (Capacity > RandomResources.randomUranium)
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + RandomResources.randomUranium;
                                    RandomResources.randomUranium = RandomResources.randomUranium - RandomResources.randomUranium;
                                    Capacity -= RandomResources.randomUranium;
                                }
                                else
                                {
                                    PlayerPlanetScript.uranium = PlayerPlanetScript.uranium + Capacity;
                                    RandomResources.randomUranium = RandomResources.randomUranium - Capacity;
                                    Capacity -= Capacity;
                                }
                            }
                            else
                            {
                                PlayerPlanetScript.iron = PlayerPlanetScript.iron + Capacity;
                                RandomResources.randomIron = RandomResources.randomIron - Capacity;
                                Capacity -= Capacity;
                            }
                        }
                        else
                        {
                            PlayerPlanetScript.iron = PlayerPlanetScript.iron + 3000;
                            RandomResources.randomIron = RandomResources.randomIron - 3000;
                            Capacity -= Capacity;
                        }

                        CargoArrived7 = true;
                        Capacity = 3000;
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