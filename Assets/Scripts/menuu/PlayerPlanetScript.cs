using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerPlanetScript : MonoBehaviour
{

    public Text playerIronText;
    public Text playerFuelText;
    public Text playerUraniumText;
    public Text playerCurrencyText;
    public Text playerPowerText;

    public static int iron = 500;
    public static int currency = 0;
    public static int fuel = 0;
    public static float power = 100;
    public static int uranium = 0;
    public static float MultiplyMode = 0;

    public static float second = 1;


    


    // Start is called before the first frame update
    void Start()
    {
        uranium -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        playerIronText.text = "IRON : " + iron;
        playerFuelText.text = "FUEL : " + fuel;
        playerUraniumText.text = "URANIUM : " + uranium;
        //playerCurrencyText.text = "CURRENCY : " + currency;
        playerPowerText.text = "POWER : " + power + " Gen(" + (MultiplyMode * -1) +")";

        if ( fuel < 1)
        {
            fuel = 0;
        }

        second -= Time.deltaTime;

        

        if (power < 2000)
        {

            if (second <= 0)
            {

                power -= 1 * MultiplyMode;
                second += 1;
            }
        }

        if(power <= 0)
        {
            SceneManager.LoadScene(0);
            Debug.Log("game over");
        }

    }
}
