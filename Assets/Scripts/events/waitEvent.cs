using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitEvent : MonoBehaviour {
    EventBase myEvent;

    [SerializeField]
    float waitTime = 1;

    private float currentTime = 0;
	// Use this for initialization
	void Start () {
        myEvent = GetComponent<EventBase>();
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if (currentTime >= waitTime)
            myEvent.setComplete();
	}
}
