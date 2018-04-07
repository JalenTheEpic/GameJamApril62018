using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {
    public Dictionary<Item.Items, bool> mItems;
    private Camera mCam;
	// Use this for initialization
	void Start () {
        mCam = this.GetComponentInChildren<Camera>();
        mItems = new Dictionary<Item.Items, bool>
        {
            { Item.Items.Key1, false }
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
            
            // Do something with the object that was hit by the raycast.
        }
    }
}
