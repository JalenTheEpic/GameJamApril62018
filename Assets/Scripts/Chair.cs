using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour {
    Camera mCam;
	// Use this for initialization
	void Start () {
        mCam = this.GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Sit();
        }
        Ray ray = mCam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction, Color.red);
    }

    void Sit()
    {
        RaycastHit hit;
        Ray ray = mCam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 2);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Chair" && hit.distance <= 1)
            {
                GameObject objectHit = hit.transform.gameObject;         
            }

            // Do something with the object that was hit by the raycast.
        }
    }
}
