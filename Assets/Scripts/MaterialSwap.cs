using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwap : MonoBehaviour
{
    private Camera myCamera;
    public float maxAltitude;
    public GameObject planet;
    public Material Outline;
    public Material GasGiant1;

    // Start is called before the first frame update
    void Start()
    {
        myCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float camAltitude = transform.position.y;

        if (camAltitude > maxAltitude)
        {
            planet.GetComponent<MeshRenderer>().material = Outline;
        } else if (camAltitude < maxAltitude) {
            planet.GetComponent<MeshRenderer>().material = GasGiant1;
        }
    }
}
