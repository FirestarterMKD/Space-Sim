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
    public GameObject canvasObject7;

    public float speed = 15f;
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
        canvasObject7.SetActive(false);





    }

    // Update is called once per frame
    void Update()
    {
        checkPlanet1();
        checkPlanet2();
        checkPlanet3();
        checkPlanet4();
        checkPlanet5();
        checkPlanet6();
        checkPlanet7();

    }

    void checkPlanet1()
    {
        target = Planet.transform;
        if (Input.GetKey("1"))
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        }
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            canvasObject1.SetActive(true);
            canvasObject2.SetActive(false);
            canvasObject3.SetActive(false);
            canvasObject4.SetActive(false);
            canvasObject5.SetActive(false);
            canvasObject6.SetActive(false);
            canvasObject7.SetActive(false);
        }
    }

    void checkPlanet2()
    {
        target = PlanetTwo.transform;
        if (Input.GetKey("2"))
        {
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
                canvasObject7.SetActive(false);

            }

            }
    }

    void checkPlanet3()
    {
        target = PlanetThree.transform;
        if (Input.GetKey("3"))
        {
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
                canvasObject7.SetActive(false);
            }

            }
    }

    void checkPlanet4()
    {
        target = PlanetFour.transform;
        if (Input.GetKey("4"))
        {
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
                canvasObject7.SetActive(false);
            }

            }
    }

    void checkPlanet5()
    {
        target = PlanetFive.transform;
        if (Input.GetKey("5"))
        {
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
                canvasObject7.SetActive(false);
            }

            }
    }

    void checkPlanet6()
    {
        target = PlanetSix.transform;
        if (Input.GetKey("6"))
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(true);
                canvasObject7.SetActive(false);
            }

            }
    }

    void checkPlanet7()
    {
        target = PlanetSeven.transform;
        if (Input.GetKey("7"))
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                canvasObject1.SetActive(false);
                canvasObject2.SetActive(false);
                canvasObject3.SetActive(false);
                canvasObject4.SetActive(false);
                canvasObject5.SetActive(false);
                canvasObject6.SetActive(false);
                canvasObject7.SetActive(true);
            }
            }
    }


}

