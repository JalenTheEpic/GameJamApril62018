using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueEvent : MonoBehaviour {
    EventBase myEvent;

    [SerializeField]
    string myText = "Hello";

    [SerializeField]
    float myTime = 0;

    public Dialogue UIObject;

	// Use this for initialization
	void Start () {
        myEvent = GetComponent<EventBase>();

        print(myText);
        UIObject.Display(myText, myTime);
        myEvent.setComplete();
	}
	
}
