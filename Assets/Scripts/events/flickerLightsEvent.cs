using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickerLightsEvent : MonoBehaviour {
    public EventBase myEvent;
    
    GameObject lightObject;

    lightEffects lightEffect;

    [SerializeField]
    float flickerTime = 2.83f;
    [SerializeField]
    float flickerRate = .11f;

	// Use this for initialization
	void Start () {
        myEvent = GetComponent<EventBase>();
        lightObject = GameObject.Find("mainLights");

        lightEffect = lightObject.GetComponent<lightEffects>();
        lightEffect.startFlicker(flickerTime, flickerRate);
	}
	
	// Update is called once per frame
	void Update () {
		if (!lightEffect.isFlickering)
        {
            myEvent.setComplete();
        }
	}
}
