using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomResources : MonoBehaviour
{
    public int randomIron;
    public int randomRawFuel;
    public int randomUranium;
    public int Possibility;

    public int Iron;
    public int Fuel;
    public int Uranium;

    public GameObject canvas;


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
        Text ironText = canvas.transform.GetChild(0).GetComponent<Text>();
        ironText.text = "Iron: " + randomIron;

        Text FuelText = canvas.transform.GetChild(1).GetComponent<Text>();
        FuelText.text = "Uranium: " + randomRawFuel;

        Text uraniumText = canvas.transform.GetChild(2).GetComponent<Text>();
        uraniumText.text = "Uranium: " + randomUranium;


    }
}
