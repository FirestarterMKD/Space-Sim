using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomResources : MonoBehaviour
{
    private int randomIron;
    private int randomRawFuel;
    private int randomUranium;

    

    void Start()
    {
        randomIron = Random.Range(10, 1000);
        randomRawFuel = Random.Range(10, 200);
        randomUranium = Random.Range(0, 50);

        Text ironText = GameObject.Find(gameObject.name + "/IronTxt").GetComponent<Text>();
        ironText.text = "Iron: " + randomIron;
        Text fuelText = GameObject.Find(gameObject.name + "/FuelText").GetComponent<Text>();
        fuelText.text = "Raw Fuel: " + randomRawFuel;
        Text UraniumText = GameObject.Find(gameObject.name + "/UraniumText").GetComponent<Text>();
        UraniumText.text = "Uranium: " + randomUranium;
    }
}
