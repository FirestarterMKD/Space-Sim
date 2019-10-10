using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomResources : MonoBehaviour
{
    public int randomIron;
    public int randomCurrency;
    public int randomRawFuel;
    public int randomUranium;
    void Start()
    {
        randomIron = Random.Range(10, 1000);
        randomCurrency = Random.Range(10, 5000);
        randomRawFuel = Random.Range(10, 200);
        randomUranium = Random.Range(0, 50);

        Text ironText = GameObject.Find(gameObject.name + "/IronTxt").GetComponent<Text>();
        ironText.text = "Iron: " + randomIron;
        Text currencyText = GameObject.Find(gameObject.name + "CurrencyText").GetComponent<Text>();
        currencyText.text = "Currency: " + randomCurrency;
        Text fuelText = GameObject.Find(gameObject.name + "/FuelText").GetComponent<Text>();
        fuelText.text = "Raw Fuel: " + randomRawFuel;
        Text UraniumText = GameObject.Find(gameObject.name + "/UraniumText").GetComponent<Text>();
        UraniumText.text = "Uranium: " + randomUranium;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
