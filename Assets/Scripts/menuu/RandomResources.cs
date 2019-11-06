using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomResources : MonoBehaviour
{
    private int randomIron;
    private int randomRawFuel;
    private int randomUranium;
    public int Possibility;





    void Start()
    {

        Possibility = Random.Range(1, 100);
        randomIron = Random.Range(500, 12000);
        randomRawFuel = Random.Range(10, 200);

        if (Possibility > 80)
        {
            randomUranium = Random.Range(0, 50);
        }
        else
        {
            randomUranium = 0;
        }

        Text ironText = GameObject.Find(gameObject.name + "/IronTxt").GetComponent<Text>();
        ironText.text = "Iron: " + randomIron;
        Text fuelText = GameObject.Find(gameObject.name + "/FuelText").GetComponent<Text>();
        fuelText.text = "Raw Fuel: " + randomRawFuel;
        Text UraniumText = GameObject.Find(gameObject.name + "/UraniumText").GetComponent<Text>();
        UraniumText.text = "Uranium: " + randomUranium;
    }
}
