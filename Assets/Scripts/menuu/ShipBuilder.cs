using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipBuilder : MonoBehaviour
{
    public InputField quantity;
    private int valueCargo;
    private int valueScout;
    private int currentQuantityCargo = 0;
    private int currentQuantityScout = 0;
    public static string currentTextCargo;
    public static string currentTextScout;
    public static int CargoCostIron = 500;
    public static int ScoutCostIron = 100;
    void Start()
    {

    }
    public void clickBuyCargo()
    {   
        int.TryParse(quantity.text, out valueCargo);
        if (PlayerPlanetScript.iron >= (CargoCostIron * valueCargo))
        {
            Debug.Log(valueCargo + " cargo started building");
            currentQuantityCargo += valueCargo;
            currentTextCargo = currentQuantityCargo.ToString();
            PlayerPlanetScript.iron -= (CargoCostIron * valueCargo);
        }
        else
        {
            Debug.Log("Not Enough Resources");
        }
        
    }
    public void clickBuyScout()
    {
        int.TryParse(quantity.text, out valueScout);
        if (PlayerPlanetScript.iron >= (ScoutCostIron * valueScout))
        {
            Debug.Log(valueScout + " scout started building");
            currentQuantityScout += valueScout;
            currentTextScout = currentQuantityScout.ToString();
            PlayerPlanetScript.iron -= (ScoutCostIron * valueScout);
        }
        else
        {
            Debug.Log("Not Enough Resources");
        }
    }
}
