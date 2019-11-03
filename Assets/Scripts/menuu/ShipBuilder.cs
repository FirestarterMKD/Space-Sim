using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipBuilder : MonoBehaviour
{
    public InputField quantity;
    private int valueCargo;
    private int valueScout;
    public static int currentQuantityCargo = 0;
    public static int currentQuantityScout = 0;
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
        if (valueCargo > 0)
        {

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
        else
        {
            Debug.Log("The number you entered should be positive.");
        }
        
    }
    public void clickBuyScout()
    {
        int.TryParse(quantity.text, out valueScout);
        if (valueScout > 0)
        {
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
        else
        {
            Debug.Log("The number you entered should be positive.");
        }

    }
}
