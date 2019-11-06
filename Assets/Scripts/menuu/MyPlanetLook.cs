using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlanetLook : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scout;
    public GameObject cargo;
    public GameObject scout2;
    public GameObject cargo2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShipBuilder.currentQuantityScout > 0)
        {
            scout.SetActive(true);
            scout2.SetActive(true);
        }
        else
        {
            scout.SetActive(false);
            scout2.SetActive(false);
        }
        if (ShipBuilder.currentQuantityCargo > 0)
        {
            cargo.SetActive(true);
            cargo2.SetActive(true);
        }
        else
        {
            cargo.SetActive(false);
            cargo2.SetActive(false);
        }
    }
}
