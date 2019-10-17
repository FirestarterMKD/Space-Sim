using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouHaveScript : MonoBehaviour
{
    public Text youHaveText = null;
    void Start()
    {
        
    }
    void Update()
    {
        youHaveText.text = "You Have: " + ShipBuilder.currentText;
    }
}
