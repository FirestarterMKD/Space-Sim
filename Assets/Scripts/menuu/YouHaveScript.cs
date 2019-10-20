using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouHaveScript : MonoBehaviour
{
    public Text youHaveTextCargo = null;
    public Text youHaveTextScout = null;
    void Start()
    {
        
    }
    void Update()
    {
        youHaveTextCargo.text = "You Have: " + ShipBuilder.currentTextCargo;
        youHaveTextScout.text = "You Have: " + ShipBuilder.currentTextScout;
    }
}
