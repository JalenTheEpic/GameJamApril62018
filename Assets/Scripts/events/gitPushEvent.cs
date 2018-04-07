using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gitPushEvent : MonoBehaviour {
    EventBase myEvent;

    [SerializeField]
    GameObject computer;

    GitPush computerGit;

	// Use this for initialization
	void Start () {
        myEvent = GetComponent<EventBase>();

        computerGit = computer.GetComponent<GitPush>();
	}
	
	// Update is called once per frame
	void Update () {
        if (computerGit.complete)
            myEvent.setComplete();
	}
}
