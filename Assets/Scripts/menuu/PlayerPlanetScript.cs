using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPlanetScript : MonoBehaviour
{

    public Text playerIronText;
    public Text playerFuelText;
    public Text playerUraniumText;
    public Text playerCurrencyText;

    public static int iron = 500;
    public static int currency = 0;
    public static int fuel = 0;
    public static int uranium = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerIronText.text = "IRON : " + iron;
        playerFuelText.text = "FUEL : " + fuel;
        playerUraniumText.text = "URANIUM : " + uranium;
        playerCurrencyText.text = "CURRENCY : " + currency;
    }
}
