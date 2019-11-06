using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomResources : MonoBehaviour
{
    private static int randomIron;
    private static int randomRawFuel;
    private static int randomUranium;
    private static int Possibility;

    public int Iron;
    public int Fuel;
    public int Uranium;


    void Start()
    {

        Possibility = Random.Range(1, 100);
        randomIron = Random.Range(500, 12000);
        randomRawFuel = Random.Range(0, 20);

        if (Possibility > 80)
        {
            randomUranium = Random.Range(0, 500);
        }
        else
        {
            randomUranium = 0;
        }
        Iron = randomIron;
        Fuel = randomRawFuel;
        Uranium = randomUranium;
        

        
    }
    void Update()
    {
        Text ironText = GameObject.Find(gameObject.name + "/IronTxt").GetComponent<Text>();
        ironText.text = "Iron: " + randomIron;
        Text fuelText = GameObject.Find(gameObject.name + "/FuelText").GetComponent<Text>();
        fuelText.text = "Raw Fuel: " + randomRawFuel;
        Text UraniumText = GameObject.Find(gameObject.name + "/UraniumText").GetComponent<Text>();
        UraniumText.text = "Uranium: " + randomUranium;

    }
}
