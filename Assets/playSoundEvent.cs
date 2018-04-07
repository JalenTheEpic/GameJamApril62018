using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundEvent : MonoBehaviour {

    EventBase myEvent;

    [SerializeField]
    GameObject mAudio;

	// Use this for initialization
	void Start () {
        myEvent = GetComponent<EventBase>();

        mAudio.GetComponent<AudioSource>().Play();

        myEvent.setComplete();	
	}
	
	
}
