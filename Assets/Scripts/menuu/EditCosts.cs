using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditCosts : MonoBehaviour
{
    public int PlayerStartIron;
    public int PlayerStartFuel;
    public int PlayerStartUranium;
    public int PlayerStartCurrency;
    public int PlayerStartPower;
    public int PowerUse;
    public int CargoIronCost;
    public int ScoutIronCost;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPlanetScript.iron = PlayerStartIron;
        PlayerPlanetScript.uranium = PlayerStartUranium;
        PlayerPlanetScript.fuel = PlayerStartFuel;
        PlayerPlanetScript.currency = PlayerStartCurrency;
        PlayerPlanetScript.power = PlayerStartPower;
        ShipBuilder.CargoCostIron = CargoIronCost;
        ShipBuilder.ScoutCostIron = ScoutIronCost;
        PlayerPlanetScript.MultiplyMode = PowerUse;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
