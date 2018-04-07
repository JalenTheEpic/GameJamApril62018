using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxColliderEvent : MonoBehaviour {

    public EventBase myEvent;

	// Use this for initialization
	void Start () {
        myEvent = GetComponent<EventBase>();
	}
	
	

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            myEvent.setComplete();
    }
}
