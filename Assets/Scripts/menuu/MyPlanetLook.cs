using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlanetLook : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scout;
    public GameObject cargo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShipBuilder.currentQuantityScout > 0)
        {
            scout.SetActive(true);
        }
        else
        {
            scout.SetActive(false);
        }
        if (ShipBuilder.currentQuantityCargo > 0)
        {
            cargo.SetActive(true);
        }
        else
        {
            cargo.SetActive(false);
        }
    }
}
