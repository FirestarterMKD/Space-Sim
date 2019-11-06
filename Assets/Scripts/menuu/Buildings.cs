using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buildings : MonoBehaviour
{
    // Start is called before the first frame update
    public int SolarPlant = 0;
    public int NuclearReactor = 0;
    public static int ShipYard = 0;
    public int Refinery = 0;

    public int CostShipYard = 1000;
    public int CostSolarPlant = 1000;
    public int CostNuclearReactor = 1000;
    public int CostRefinery = 1000;

    public Text ShipYardLvlTxt;
    public Text SolarPlantLvlTxt;
    public Text RefinaryLvlTxt;
    public Text NuclearReactorLvlTxt;
    void Start()
    {

    }

    void Update()
    {
        ShipYardLvlTxt.text = "COST: " + CostShipYard + " Iron /" + " LVL: " + ShipYard.ToString();
        SolarPlantLvlTxt.text = "COST: " + CostSolarPlant + " Iron /" + " LVL: " + SolarPlant.ToString();
        RefinaryLvlTxt.text = "COST: " + CostRefinery + " Iron /" + " LVL: " + Refinery.ToString();
        NuclearReactorLvlTxt.text = "COST: " + CostNuclearReactor + " Uranium /" + " LVL: " + NuclearReactor.ToString();
    }

    public void BuildShipYard()
    {
        if (PlayerPlanetScript.iron >= CostShipYard)
        {
            ShipYard++;
            PlayerPlanetScript.iron = PlayerPlanetScript.iron - CostShipYard;
            CostShipYard = (CostShipYard * 2);
        }
        else
        {
            Debug.Log("Not Enough Resources");
        }
    }

    public void BuildSolarPlant()
    {
        if (PlayerPlanetScript.iron >= CostSolarPlant)
        {
            SolarPlant++;
            PlayerPlanetScript.iron = PlayerPlanetScript.iron - CostSolarPlant;
            CostSolarPlant = CostSolarPlant * 4;
            PlayerPlanetScript.MultiplyMode -= 2;
        }
        else
        {
            Debug.Log("Not Enough Resources");
        }
    }

    public void BuildRefinery()
    {
        if (PlayerPlanetScript.iron >= CostRefinery)
        {
            Refinery++;
            PlayerPlanetScript.iron = PlayerPlanetScript.iron - CostRefinery;
            CostRefinery = CostRefinery * 3;
        }
        else
        {
            Debug.Log("Not Enough Resources");
        }
    }

    public void BuildNuclearReactor()
    {
        if (PlayerPlanetScript.uranium >= CostNuclearReactor)
        {
            NuclearReactor++;
            PlayerPlanetScript.iron = PlayerPlanetScript.iron - CostNuclearReactor;
            CostNuclearReactor = CostNuclearReactor * 2;

            PlayerPlanetScript.MultiplyMode -= 50;
        }
        else
        {
            Debug.Log("Not Enough Resources");
        }
    }
}
