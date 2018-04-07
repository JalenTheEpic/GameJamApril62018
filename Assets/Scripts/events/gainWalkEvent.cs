using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gainWalkEvent : MonoBehaviour {

    EventBase myEvent;


    UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

    // Use this for initialization
    void Start()
    {
        myEvent = GetComponent<EventBase>();
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        controller.setSpeed(2.61f);
        myEvent.setComplete();

		
	}
}
