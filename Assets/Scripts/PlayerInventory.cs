using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {
    public Dictionary<Items, bool> mItems;
    private Camera mCam;
	// Use this for initialization
	void Start () {
        mCam = this.GetComponentInChildren<Camera>();
        mItems = new Dictionary<Items, bool>
        {
            { Items.Key1, false }, { Items.Dick, false }
        };
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pickup();
        }
        Ray ray = mCam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction);
    }

    void Pickup()
    {
        RaycastHit hit;
        Ray ray = mCam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 2);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Item" && hit.distance <= 1)
            {
                
                GameObject objectHit = hit.transform.gameObject;
                Item i = objectHit.GetComponent<Item>();
                Debug.Log(i.desc);
                mItems[i.item] = true;
                objectHit.SetActive(false);
            }
            else if (hit.transform.tag == "PC" && hit.distance <= 2)
            {
                GitPush pcGit = hit.transform.gameObject.GetComponent<GitPush>();
                if (pcGit.turnedOn)
                {
                    pcGit.push();
                }
            }
            else if (hit.transform.tag == "Flashlight" && hit.distance <= 2)
            {
                print("found it");
                transform.Find("Flashlight").gameObject.SetActive(true);
            }

            // Do something with the object that was hit by the raycast.
        }
    }
}
