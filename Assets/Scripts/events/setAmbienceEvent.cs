using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAmbienceEvent : MonoBehaviour {
    EventBase myEvent;

    [SerializeField]
    Color newColor = new Color(15, 15, 15);

	// Use this for initialization
	void Start () {
        myEvent = GetComponent<EventBase>();

        RenderSettings.ambientLight = newColor;
        myEvent.setComplete();	
	}
	

}
