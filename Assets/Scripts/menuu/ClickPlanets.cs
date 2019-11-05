using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickPlanets : MonoBehaviour
{
    public GameObject cameraOne;
    public GameObject cameraTwo;
    public GameObject canvasObject1;
    public GameObject canvasObject2;
    public GameObject canvasObject3;
    public GameObject canvasObject4;
    public GameObject canvasObject5;
    public GameObject canvasObject6;

    void Start()
    {
        canvasObject1.SetActive(false);
        canvasObject2.SetActive(false);
        canvasObject3.SetActive(false);
        canvasObject4.SetActive(false);
        canvasObject5.SetActive(false);
        canvasObject6.SetActive(false);
    }

    void Update()
    {
        /*if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            {
                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    if (hit.transform.name == "ColliderPlanetOne")
                    {
                        canvasObject1.SetActive(false);
                        canvasObject2.SetActive(false);
                        canvasObject3.SetActive(false);
                        canvasObject4.SetActive(false);
                        canvasObject5.SetActive(false);
                        canvasObject6.SetActive(false);
                        canvasObject7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetTwo")
                    {
                        canvasObject1.SetActive(false);
                        canvasObject2.SetActive(true);
                        canvasObject3.SetActive(false);
                        canvasObject4.SetActive(false);
                        canvasObject5.SetActive(false);
                        canvasObject6.SetActive(false);
                        canvasObject7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetThree")
                    {
                        canvasObject1.SetActive(false);
                        canvasObject2.SetActive(false);
                        canvasObject3.SetActive(true);
                        canvasObject4.SetActive(false);
                        canvasObject5.SetActive(false);
                        canvasObject6.SetActive(false);
                        canvasObject7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetFour")
                    {
                        canvasObject1.SetActive(false);
                        canvasObject2.SetActive(false);
                        canvasObject3.SetActive(false);
                        canvasObject4.SetActive(true);
                        canvasObject5.SetActive(false);
                        canvasObject6.SetActive(false);
                        canvasObject7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetFive")
                    {
                        canvasObject1.SetActive(false);
                        canvasObject2.SetActive(false);
                        canvasObject3.SetActive(false);
                        canvasObject4.SetActive(false);
                        canvasObject5.SetActive(true);
                        canvasObject6.SetActive(false);
                        canvasObject7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetSix")
                    {
                        canvasObject1.SetActive(false);
                        canvasObject2.SetActive(false);
                        canvasObject3.SetActive(false);
                        canvasObject4.SetActive(false);
                        canvasObject5.SetActive(false);
                        canvasObject6.SetActive(true);
                        canvasObject7.SetActive(false);
                    }
                    if (hit.transform.name == "ColliderPlanetSeven")
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
        }*/
    }

}
