using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveKeyEvent : MonoBehaviour {
    EventBase myEvent;


    [SerializeField]
    Items itemGiven;

	void Start () {
        myEvent = GetComponent<EventBase>();

        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>().mItems[itemGiven] = true;

        myEvent.setComplete();
	}
	
}
