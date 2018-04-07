using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightEffects : MonoBehaviour {



    // Point Lights
    Light[] mLights;


    // Light Material stuff
    [SerializeField]
    Material lightMaterial;

    Renderer[] lightRenderers;


    // Light Properties
    private float flickerTime = 5f;
    private float flickerRate = .05f;

    

    private int lightStatus = 1;




    //Flicker variables
    public bool isFlickering = false;

    private float curFlickerRateTime = 0;
    private float curFlickerTime = 0;

    private float realFlickerRate;
    

    void Start () {
        mLights = GetComponentsInChildren<Light>();
        
        //Emission color must be set at start. This function edits the actual material and doesn't reset on game end
        lightMaterial.SetColor("_EmissionColor", new Color(255, 255, 255));

        realFlickerRate = Random.Range(flickerRate - .1f, flickerRate + .15f);

    }
	
	// Update is called once per frame
	void Update () {

        if (isFlickering)
            flickerLights();
	}

    public void startFlicker(float time, float rate)
    {
        flickerTime = time;
        flickerRate = rate;
        isFlickering = true;
    }


    private void flickerLights()
    {
        curFlickerTime += Time.deltaTime;
        curFlickerRateTime += Time.deltaTime;
        if (curFlickerRateTime >= realFlickerRate)
        {
            realFlickerRate = Random.Range(flickerRate - .1f, flickerRate + .15f);
            curFlickerRateTime = 0;
            switchLights();
        }
        if (curFlickerTime >= flickerTime)
        {
            curFlickerTime = 0;
            isFlickering = false;
            lightStatus = 0;
            switchLights();
        }
        



    }

    public void switchLights()
    {
        int emission;
        if (lightStatus == 1)
        {
            lightStatus = 0;
            emission = 0;
        }
        else
        {
            lightStatus = 1;
            emission = 255;
        }
        lightMaterial.SetColor("_EmissionColor", new Color(emission, emission, emission));
        
        for (int i = 0; i < mLights.Length; i++)
        {
            mLights[i].intensity = emission - 254.5f;
        }
    }

    
}
