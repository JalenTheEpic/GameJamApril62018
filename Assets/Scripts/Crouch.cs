using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour {
    CharacterController characterController;
    UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpController;
    public float standingHeight;
    public float crouchHeight = .5f;
    // Use this for initialization
    void Start () {

        characterController = GetComponent<CharacterController>();
        fpController = GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        standingHeight = characterController.height;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftControl))
        {
            characterController.height = crouchHeight;
            fpController.m_IsCrouching = true;
            
        }
        else
        {
            characterController.height = standingHeight;
            fpController.m_IsCrouching = false;
        }
	}
}
