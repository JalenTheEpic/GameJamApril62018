using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBase : MonoBehaviour {

    private bool eventCompleted = false;

    public bool isCompleted()
    {
        return eventCompleted;
    }

    public void setComplete()
    {
        eventCompleted = true;
    }

    
}
