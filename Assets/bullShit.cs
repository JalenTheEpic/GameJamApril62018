using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullShit : MonoBehaviour {
    AudioSource audioSource;

    GameObject player;

    [SerializeField]
    Transform fuckMeDaddy;

    bool hasPlayed = false;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();

        player = GameObject.FindGameObjectWithTag("Player");	
	}
	
	// Update is called once per frame
	void Update () {
		if (audioSource.isPlaying)
        {
            if (!hasPlayed)
            {
                Transform parent = transform.parent;
                MeshRenderer[] meshes = parent.GetComponentsInChildren<MeshRenderer>();
                for (int i = 0; i < meshes.Length; i++)
                {
                    meshes[i].enabled = false;
                    hasPlayed = true;
                }
            }
            player.GetComponentInChildren<Camera>().transform.LookAt(fuckMeDaddy.position);
            player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().setSpeed(0);
            player.GetComponentInChildren<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
            
        }
	}
}
