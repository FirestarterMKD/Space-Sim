using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditCosts : MonoBehaviour
{
    public int CargoIron;
    public int ScoutIron;

    // Start is called before the first frame update
    void Start()
    {
        ShipBuilder.CargoCostIron = CargoIron;
        ShipBuilder.ScoutCostIron = ScoutIron;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
