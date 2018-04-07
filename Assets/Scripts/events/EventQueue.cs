using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventQueue : MonoBehaviour {

    public Queue<GameObject> eventQueue = new Queue<GameObject>();

    [SerializeField]
    GameObject currentEvent;
    EventBase currentEventBase;
    
	// Use this for initialization
	void Awake () {
        foreach (Transform child in transform)
        {
            eventQueue.Enqueue(child.gameObject);
            child.gameObject.SetActive(false);
        }
        currentEvent = eventQueue.Dequeue();
        currentEventBase = currentEvent.GetComponent<EventBase>();
        currentEvent.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if (currentEventBase.isCompleted())
        {
            Destroy(currentEvent);
            if (eventQueue.Count < 1)
            {
                Destroy(gameObject);
                return;
            }
            currentEvent = eventQueue.Dequeue();
            currentEventBase = currentEvent.GetComponent<EventBase>();
            currentEvent.SetActive(true);
        }
	}
}
