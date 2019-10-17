using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipBuilder : MonoBehaviour
{
    public InputField quantity;
    private int currentQuantity = 0;
    private int value;
    public static string currentText;
    void Start()
    {

    }
    public void clickBuy()
    {
        int.TryParse(quantity.text, out value);
        Debug.Log(value +  " ships started building");
        currentQuantity += value;
        currentText = currentQuantity.ToString();
    }
}
