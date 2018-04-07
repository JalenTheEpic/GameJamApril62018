using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {

    public GameObject mCharacter;

    private Camera mCam;
	// Use this for initialization
	void Start () {
        mCam = mCharacter.GetComponent<Camera>();
  
        this.transform.localPosition = mCam.transform.localPosition;
        this.transform.localRotation = mCam.transform.localRotation;
   

    }
	
	// Update is called once per frame
	void Update () {
        this.transform.localPosition = mCam.transform.localPosition;
        this.transform.localRotation = mCam.transform.localRotation;
    }
}
