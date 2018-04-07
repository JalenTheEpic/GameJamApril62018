using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setWalkSpeedEvent : MonoBehaviour {

    EventBase myEvent;

    [SerializeField]
    float walkSpeed = 0;

    UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

    // Use this for initialization
    void Start()
    {
        myEvent = GetComponent<EventBase>();
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        controller.setSpeed(walkSpeed);
        myEvent.setComplete();
    }

}
