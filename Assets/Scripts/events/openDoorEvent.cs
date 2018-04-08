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
        myEvent = GetComponent<EventBase>();
        Door mDoor = door.GetComponent<Door>();
        mDoor.open = toOpen;

        mDoor.done = false;

        if (toOpen)
            mDoor.audioSource.clip = mDoor.audioClips[0];
        else
            mDoor.audioSource.clip = mDoor.audioClips[1];

        myEvent.setComplete();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
