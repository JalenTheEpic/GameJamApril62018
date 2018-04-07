using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    Animation mAnim;

    public enum EnemyState { INIT, SPAWN_DOWNSTAIRS, WALK };
    EnemyState enemyState = EnemyState.INIT;

    Vector3 nextWalkPosition = new Vector3(-2f, -3.5f, -9f); 

	// Use this for initialization
	void Start () {
        mAnim = GetComponent<Animation>();

        
	}

	
    public void startState(EnemyState state)
    {
        switch (state)
        {
            case EnemyState.SPAWN_DOWNSTAIRS:
                enemyState = EnemyState.SPAWN_DOWNSTAIRS;
                transform.position = new Vector3(-7.704f, -3.5f, -9.106069f);
                transform.rotation = Quaternion.Euler(0, 90, 0);
                break;
            case EnemyState.WALK:
                enemyState = EnemyState.WALK;
                mAnim.Play("Walk");
                break;
        }

        
    }



	// Update is called once per frame
	void Update () {
		switch (enemyState){
            case EnemyState.WALK:
                transform.Translate(Vector3.forward * 1 * Time.deltaTime);

                if ((nextWalkPosition - transform.position).magnitude <= .3f)
                    transform.rotation = Quaternion.Euler(0, 131.41f, 0);
                break;
        }
	}
}
