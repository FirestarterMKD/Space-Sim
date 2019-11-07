
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetswapper : MonoBehaviour
{
    public MouseOrbitImproved mouseOrbitImprovedTarget;
    public GameObject planetOne;
    public GameObject PlanetTwo;
    public GameObject PlanetThree;
    public GameObject PlanetFour;
    public GameObject PlanetFive;
    public GameObject PlanetSix;
    GameObject PlanetSeven;
    GameObject PlanetEight;
    GameObject PlanetNine;
    GameObject PlanetTen;
    public GameObject cameraOne;
    public GameObject cameraTwo;
    AudioListener cameraOneAudioLis;
    AudioListener cameraTwoAudioLis;

    // Start is called before the first frame update
    void Start()
    {
        /*planetOne = GameObject.FindWithTag("PlanetOne");
        PlanetTwo = GameObject.FindWithTag("PlanetTwo");
        PlanetThree = GameObject.FindWithTag("PlanetThree");
        PlanetFour = GameObject.FindWithTag("PlanetFour");
        PlanetFive = GameObject.FindWithTag("PlanetFive");
        PlanetSix = GameObject.FindWithTag("PlanetSix");*/
        PlanetSeven = GameObject.FindWithTag("PlanetSeven");
        PlanetEight = GameObject.Find("ColliderGasGiantOne");
        PlanetNine = GameObject.Find("ColliderGasGiantTwo");
        PlanetTen = GameObject.Find("ColliderGasGiantThree");
        cameraOne = GameObject.Find("CameraOne");
        cameraTwo = GameObject.Find("CameraTwo");
        cameraOneAudioLis = cameraOne.GetComponent<AudioListener>();
        cameraTwoAudioLis = cameraTwo.GetComponent<AudioListener>();
        cameraTwoAudioLis.enabled = false;
        cameraOne.SetActive(true);
        cameraTwo.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlanetChangeOne()
    {
        mouseOrbitImprovedTarget.target = planetOne.transform;
    }

    public void PlanetChangeTwo()
    {
        mouseOrbitImprovedTarget.target = PlanetTwo.transform;
    }
    public void PlanetChangeThree()
    {
        mouseOrbitImprovedTarget.target = PlanetThree.transform;
    }
    public void PlanetChangeFour()
    {
        mouseOrbitImprovedTarget.target = PlanetFour.transform;
    }
    public void PlanetChangeFive()
    {
        mouseOrbitImprovedTarget.target = PlanetFive.transform;
    }
    public void PlanetChangeSix()
    {
        mouseOrbitImprovedTarget.target = PlanetSix.transform;
    }
    public void PlanetChangeSeven()
    {
        mouseOrbitImprovedTarget.target = PlanetSeven.transform;
    }
    public void PlanetChangeEight()
    {
        mouseOrbitImprovedTarget.target = PlanetEight.transform;
    }
    public void PlanetChangeNine()
    {
        mouseOrbitImprovedTarget.target = PlanetNine.transform;
    }
    public void PlanetChangeTen()
    {
        mouseOrbitImprovedTarget.target = PlanetTen.transform;
    }
    public void ChangeBack()
    {
        cameraTwo.SetActive(false);
        cameraTwoAudioLis.enabled = false;

        cameraOneAudioLis.enabled = true;
        cameraOne.SetActive(true);
    }
    public void ButtonChange()
    {
        cameraTwo.SetActive(true);
        cameraTwoAudioLis.enabled = true;

        cameraOneAudioLis.enabled = false;
        cameraOne.SetActive(false);
    }
}

