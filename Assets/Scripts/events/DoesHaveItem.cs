using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoesHaveItem : MonoBehaviour {
    EventBase mEvent;

    PlayerInventory inventory;

    [SerializeField]
    Items item;

	// Use this for initialization
	void Start () {
        mEvent = GetComponent<EventBase>();

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
	}
	
	// Update is called once per frame
	void Update () {
		if (inventory.mItems[item] == true)
        {
            mEvent.setComplete();
        }
	}
}
