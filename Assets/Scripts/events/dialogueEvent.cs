using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueEvent : MonoBehaviour {
    EventBase myEvent;

    [SerializeField]
    string myText = "Hello";

	// Use this for initialization
	void Start () {
        myEvent = GetComponent<EventBase>();

        print(myText);
        myEvent.setComplete();
	}
	
}
