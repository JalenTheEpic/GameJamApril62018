using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchLightsEvent : MonoBehaviour {
    EventBase myEvent;

	// Use this for initialization
	void Start () {
        myEvent = GetComponent<EventBase>();
        GameObject.Find("mainLights").GetComponent<lightEffects>().switchLights();
        myEvent.setComplete();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
