using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipBuilder : MonoBehaviour
{
    public InputField quantity;
    public static int valueCargo;
    public static int valueScout;

    public static int currentQuantityCargo = 0;
    public static int currentQuantityScout = 0;

    public static string currentTextCargo;
    public static string currentTextScout;

    public static int CargoCostIron = 500;
    public static int ScoutCostIron = 100;

    public static int CargoCostPower = 10;
    public static int ScoutCostPower = 5;


    private int Shipyardlvl = 0;

    void Start()
    {

    }
    public void clickBuyCargo()
    {   
        int.TryParse(quantity.text, out valueCargo);
        Shipyardlvl = Buildings.ShipYard;
        if (Shipyardlvl >= 2)
        {
            if (valueCargo > 0)
            {

                if (PlayerPlanetScript.iron >= (CargoCostIron * valueCargo))
                {
                    Debug.Log(valueCargo + " cargo started building");
                    currentQuantityCargo += valueCargo;
                    currentTextCargo = currentQuantityCargo.ToString();
                    PlayerPlanetScript.iron -= (CargoCostIron * valueCargo);
                    PlayerPlanetScript.MultiplyMode += (currentQuantityCargo * CargoCostPower);
                }
                else
                {
                    Debug.Log("Not Enough Resources");
                }
            }
            else
            {
                Debug.Log("The number you entered should be positive.");
            }
        }
        else
        {
            Debug.Log("Shipyard Should be 2");
        }
        
        
    }
    public void clickBuyScout()
    {
        int.TryParse(quantity.text, out valueScout);
        Shipyardlvl = Buildings.ShipYard;
        if (Shipyardlvl >= 1)
        {
            if (valueScout > 0)
            {
                if (PlayerPlanetScript.iron >= (ScoutCostIron * valueScout))
                {
                    Debug.Log(valueScout + " scout started building");
                    currentQuantityScout += valueScout;
                    currentTextScout = currentQuantityScout.ToString();
                    PlayerPlanetScript.iron -= (ScoutCostIron * valueScout);
                    PlayerPlanetScript.MultiplyMode += (valueScout * ScoutCostPower);
                }
                else
                {
                    Debug.Log("Not Enough Resources");
                }
            }
            else
            {
                Debug.Log("The number you entered should be positive.");
            }
        }
        else
        {
            Debug.Log("Shipyard Should be 1");
        }

    }
}
