using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoorEvent : MonoBehaviour {
    EventBase myEvent;

    [SerializeField]
    GameObject door;

    [SerializeField]
    bool toOpen = true;

    void Start () {
        door.GetComponent<Door>().open = toOpen;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
