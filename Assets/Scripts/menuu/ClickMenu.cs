using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMenu : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PreviousPanel;

    private void Start()
    {
    }
    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
        if (PreviousPanel != null)
        {
            bool isActivep = PreviousPanel.activeSelf;
            PreviousPanel.SetActive(!isActivep);
        }
    }
}
