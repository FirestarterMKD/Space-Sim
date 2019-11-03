using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPlanetMenu : MonoBehaviour
{
    public GameObject PlanetMenu1;
    public GameObject PlanetMenu2;
    public GameObject PlanetMenu3;
    public GameObject PlanetMenu4;
    public GameObject PlanetMenu5;
    public GameObject PlanetMenu6;
    public GameObject PlanetMenu7;

    void Start()
    {
        PlanetMenu1.SetActive(false);
        PlanetMenu2.SetActive(false);
        PlanetMenu3.SetActive(false);
        PlanetMenu4.SetActive(false);
        PlanetMenu5.SetActive(false);
        PlanetMenu6.SetActive(false);
        PlanetMenu7.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            {
                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    if (hit.transform.name == "ColliderPlanetOne")
                    {
                        PlanetMenu1.SetActive(true);
                        PlanetMenu2.SetActive(false);
                        PlanetMenu3.SetActive(false);
                        PlanetMenu4.SetActive(false);
                        PlanetMenu5.SetActive(false);
                        PlanetMenu6.SetActive(false);
                        PlanetMenu7.SetActive(false);

                    }
                    if (hit.transform.name == "ColliderPlanetTwo")
                    {
                        PlanetMenu1.SetActive(false);
                        PlanetMenu2.SetActive(true);
                        PlanetMenu3.SetActive(false);
                        PlanetMenu4.SetActive(false);
                        PlanetMenu5.SetActive(false);
                        PlanetMenu6.SetActive(false);
                        PlanetMenu7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetThree")
                    {
                        PlanetMenu1.SetActive(false);
                        PlanetMenu2.SetActive(false);
                        PlanetMenu3.SetActive(true);
                        PlanetMenu4.SetActive(false);
                        PlanetMenu5.SetActive(false);
                        PlanetMenu6.SetActive(false);
                        PlanetMenu7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetFour")
                    {
                        PlanetMenu1.SetActive(false);
                        PlanetMenu2.SetActive(false);
                        PlanetMenu3.SetActive(false);
                        PlanetMenu4.SetActive(true);
                        PlanetMenu5.SetActive(false);
                        PlanetMenu6.SetActive(false);
                        PlanetMenu7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetFive")
                    {
                        PlanetMenu1.SetActive(false);
                        PlanetMenu2.SetActive(false);
                        PlanetMenu3.SetActive(false);
                        PlanetMenu4.SetActive(false);
                        PlanetMenu5.SetActive(true);
                        PlanetMenu6.SetActive(false);
                        PlanetMenu7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetSix")
                    {
                        PlanetMenu1.SetActive(false);
                        PlanetMenu2.SetActive(false);
                        PlanetMenu3.SetActive(false);
                        PlanetMenu4.SetActive(false);
                        PlanetMenu5.SetActive(false);
                        PlanetMenu6.SetActive(true);
                        PlanetMenu7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetSeven")
                    {
                        PlanetMenu1.SetActive(false);
                        PlanetMenu2.SetActive(false);
                        PlanetMenu3.SetActive(false);
                        PlanetMenu4.SetActive(false);
                        PlanetMenu5.SetActive(false);
                        PlanetMenu6.SetActive(false);
                        PlanetMenu7.SetActive(true);
                    }
                }
            }
        }
    }
}
