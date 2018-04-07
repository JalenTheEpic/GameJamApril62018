using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    Animation mAnim;

    public enum EnemyState { EVENT0, EVENT1, EVENT2 };
    EnemyState enemyState = EnemyState.EVENT0;

	// Use this for initialization
	void Start () {
        mAnim = GetComponent<Animation>();

        
	}

	
    public void startState(EnemyState state)
    {
        switch (state)
        {
            case EnemyState.EVENT1:
                enemyState = EnemyState.EVENT1;
                transform.position = new Vector3(-1.83f, -3.5f, -8.16f);
                transform.LookAt(new Vector3(0, 143.808f, 0));
                break;
        }

        
    }



	// Update is called once per frame
	void Update () {
		switch (enemyState){
            case EnemyState.EVENT1:
                print("walking");
                break;
        }
	}
}
