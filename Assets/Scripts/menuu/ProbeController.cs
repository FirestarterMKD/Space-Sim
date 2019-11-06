using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeController : MonoBehaviour

{
    public GameObject canvasObject1;
    public GameObject canvasObject2;
    public GameObject canvasObject3;
    public GameObject canvasObject4;
    public GameObject canvasObject5;
    public GameObject canvasObject6;

    public float speed = 15f;
    GameObject Planet;
    GameObject PlanetTwo;
    GameObject PlanetThree;
    GameObject PlanetFour;
    GameObject PlanetFive;
    GameObject PlanetSix;
    GameObject PlanetSeven;

    private Transform target;

    public bool arrived = true;
    public bool arrived2 = true;
    public bool arrived3 = true;
    public bool arrived4 = true;
    public bool arrived5 = true;
    public bool arrived6 = true;

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

        canvasObject1.SetActive(false);
        canvasObject2.SetActive(false);
        canvasObject3.SetActive(false);
        canvasObject4.SetActive(false);
        canvasObject5.SetActive(false);
        canvasObject6.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (arrived == false)
        {
            checkPlanet1();
        }
        if (arrived2 == false)
        {
            checkPlanet2();
        }
        if (arrived3 == false)
        {
            checkPlanet3();
        }
        if (arrived4 == false)
        {
            checkPlanet4();
        }
        if (arrived5 == false)
        {
            checkPlanet5();
        }
        if (arrived6 == false)
        {
            checkPlanet6();
        }
    }

    void checkPlanet1()
    {
        target = Planet.transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            canvasObject1.SetActive(true);
            canvasObject2.SetActive(false);
            canvasObject3.SetActive(false);
            canvasObject4.SetActive(false);
            canvasObject5.SetActive(false);
            canvasObject6.SetActive(false); 
            arrived = !arrived;
        }

        if (Vector3.Distance(transform.position, target.position) > 0.005f)
        {
            canvasObject1.SetActive(false);
            canvasObject2.SetActive(false);
            canvasObject3.SetActive(false);
            canvasObject4.SetActive(false);
            canvasObject5.SetActive(false);
            canvasObject6.SetActive(false); 
        }
    }

    void checkPlanet2()
    {
        target = PlanetTwo.transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            canvasObject1.SetActive(false);
            canvasObject2.SetActive(true);
            canvasObject3.SetActive(false);
            canvasObject4.SetActive(false);
            canvasObject5.SetActive(false);
            canvasObject6.SetActive(false); 
            arrived2 = !arrived2;
        }

        if (Vector3.Distance(transform.position, target.position) > 0.005f)
        {
            canvasObject1.SetActive(false);
            canvasObject2.SetActive(false);
            canvasObject3.SetActive(false);
            canvasObject4.SetActive(false);
            canvasObject5.SetActive(false);
            canvasObject6.SetActive(false); 
        }
    }

    void checkPlanet3()
    {
        target = PlanetThree.transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(true);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(false); 

            arrived3 = !arrived3;
        }
            if (Vector3.Distance(transform.position, target.position) > 0.005f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(false); 
            }
    }

    void checkPlanet4()
    {
        target = PlanetFour.transform;
        float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(true);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(false); 
            arrived4 = !arrived4;

        }

            if (Vector3.Distance(transform.position, target.position) > 0.005f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(false); 
            }
    }

    void checkPlanet5()
    {
        target = PlanetFive.transform;
        float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(true);
                canvasObject6.SetActive(false); 
            arrived5 = !arrived5;
        }

            if (Vector3.Distance(transform.position, target.position) > 0.005f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(false); 
            }
    }

    void checkPlanet6()
    {
        target = PlanetSix.transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.002f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(true); 
            arrived6 = !arrived6;
        }
            if (Vector3.Distance(transform.position, target.position) > 0.005f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(false); 
            }
    }

    void checkPlanet7()
    {
        target = PlanetSeven.transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.002f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(false); 
            }
            if (Vector3.Distance(transform.position, target.position) > 0.005f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(false); 
            }
    }

    public void SendScout1()
    {
        if (ShipBuilder.currentQuantityScout > 0)
        {
            arrived = !arrived;
        }
        else {
            Debug.Log("You should build a scout ship first.");
        }
    }
    public void SendScout2()
    {
        if (ShipBuilder.currentQuantityScout > 0)
        {
            arrived2 = !arrived2;
        }
        else
        {
            Debug.Log("You should build a scout ship first.");
        }
    }
    public void SendScout3()
    {
        if (ShipBuilder.currentQuantityScout > 0)
        {
            arrived3 = !arrived3;
        }
        else
        {
            Debug.Log("You should build a scout ship first.");
        }
    }
    public void SendScout4()
    {
        if (ShipBuilder.currentQuantityScout > 0)
        {
            arrived4 = !arrived4;
        }
        else
        {
            Debug.Log("You should build a scout ship first.");
        }
    }
    public void SendScout5()
    {
        if (ShipBuilder.currentQuantityScout > 0)
        {
            arrived5 = !arrived5;
        }
        else
        {
            Debug.Log("You should build a scout ship first.");
        }
    }
    public void SendScout6()
    {
        if (ShipBuilder.currentQuantityScout > 0)
        {
            arrived6 = !arrived6;
        }
        else
        {
            Debug.Log("You should build a scout ship first.");
        }
    }


}

