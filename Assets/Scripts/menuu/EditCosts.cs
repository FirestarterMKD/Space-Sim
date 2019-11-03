using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditCosts : MonoBehaviour
{
    public int PlayerStartIron;
    public int PlayerStartFuel;
    public int PlayerStartUranium;
    public int PlayerStartCurrency;
    public int CargoIronCost;
    public int ScoutIronCost;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPlanetScript.iron = PlayerStartIron;
        PlayerPlanetScript.uranium = PlayerStartUranium;
        PlayerPlanetScript.fuel = PlayerStartFuel;
        PlayerPlanetScript.currency = PlayerStartCurrency;
        ShipBuilder.CargoCostIron = CargoIronCost;
        ShipBuilder.ScoutCostIron = ScoutIronCost;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
