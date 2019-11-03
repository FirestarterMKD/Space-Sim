using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetswapper : MonoBehaviour
{
    public MouseOrbitImproved mouseOrbitImprovedTarget;
    GameObject planetOne;
    GameObject PlanetTwo;
    GameObject PlanetThree;
    GameObject PlanetFour;
    GameObject PlanetFive;
    GameObject PlanetSix;
    GameObject PlanetSeven;
    GameObject cameraOne;
    GameObject cameraTwo;
    AudioListener cameraOneAudioLis;
    AudioListener cameraTwoAudioLis;

    // Start is called before the first frame update
    void Start()
    {
        planetOne = GameObject.FindWithTag("PlanetOne");
        PlanetTwo = GameObject.FindWithTag("PlanetTwo");
        PlanetThree = GameObject.FindWithTag("PlanetThree");
        PlanetFour = GameObject.FindWithTag("PlanetFour");
        PlanetFive = GameObject.FindWithTag("PlanetFive");
        PlanetSix = GameObject.FindWithTag("PlanetSix");
        PlanetSeven = GameObject.FindWithTag("PlanetSeven");
        cameraOne = GameObject.FindWithTag("MainCamera");
        cameraTwo = GameObject.FindWithTag("CamTwo");
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
    public void TargetChange()
    {
        mouseOrbitImprovedTarget.target = planetOne.transform;
    }

    public void TargetChanger()
    {
        mouseOrbitImprovedTarget.target = PlanetTwo.transform;
    }
    public void TargetChangers()
    {
        mouseOrbitImprovedTarget.target = PlanetThree.transform;
    }
    public void TargetChangerso()
    {
        mouseOrbitImprovedTarget.target = PlanetFour.transform;
    }
    public void TargetChangersob()
    {
        mouseOrbitImprovedTarget.target = PlanetFive.transform;
    }
    public void TargetChangersobe()
    {
        mouseOrbitImprovedTarget.target = PlanetSix.transform;
    }
    public void TargetChangersober()
    {
        mouseOrbitImprovedTarget.target = PlanetSeven.transform;
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
