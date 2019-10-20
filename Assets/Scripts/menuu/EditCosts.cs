using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditCosts : MonoBehaviour
{
    public int PlayerStartIron;
    public int CargoIronCost;
    public int ScoutIronCost;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPlanetScript.iron = PlayerStartIron;
        ShipBuilder.CargoCostIron = CargoIronCost;
        ShipBuilder.ScoutCostIron = ScoutIronCost;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
