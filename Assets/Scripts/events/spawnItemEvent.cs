using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnItemEvent : MonoBehaviour {
    EventBase myEvent;

    [SerializeField]
    GameObject itemToSpawn;

    [SerializeField]
    bool isActive = true;

	// Use this for initialization
	void Start () {
        myEvent = GetComponent<EventBase>();
        itemToSpawn.SetActive(isActive);
        myEvent.setComplete(); 	
	}

}
