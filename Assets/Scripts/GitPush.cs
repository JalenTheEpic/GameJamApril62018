using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GitPush : MonoBehaviour {

    public bool complete = false;

    [SerializeField]
    public bool turnedOn = false;

    private bool pushing = false;

    private float pushTime = 0;

    [SerializeField]
    float maxPushTime = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (pushing)
        {
            pushTime += Time.deltaTime;
            if (pushTime >= maxPushTime)
            {
                pushing = false;
                transform.GetChild(0).transform.Find("success").GetComponent<RawImage>().enabled = true;
                complete = true;
            }
        }
	}
    
    public void push()
    {
        pushing = true;
        print("pressed");

        
        transform.GetChild(0).transform.Find("git").GetComponent<RawImage>().enabled = true;
    }
}
