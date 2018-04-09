using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableGameObjectEvent : MonoBehaviour {

    EventBase myEvent;

    [SerializeField]
    GameObject obj;

    // Use this for initialization
    void Start()
    {
        myEvent = GetComponent<EventBase>();

        obj.SetActive(true);

        myEvent.setComplete();
    }
}
