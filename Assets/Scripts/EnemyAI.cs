using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour {

    Animation mAnim;

    public enum EnemyState { INIT, SPAWN_DOWNSTAIRS, WALK };
    EnemyState enemyState = EnemyState.INIT;

    Vector3 nextWalkPosition;

    [SerializeField]
    Queue<Vector3> enemyPath = new Queue<Vector3>();

	// Use this for initialization
	void Start () {
        
        mAnim = GetComponent<Animation>();
        Transform path = GameObject.FindGameObjectWithTag("Path").transform;
        for (int i = 0; i <= path.childCount - 1; i++)
        {
            enemyPath.Enqueue(path.GetChild(i).transform.position);
        }
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
            case EnemyState.INIT:
                mAnim.Play("Idle");
                break;
            case EnemyState.WALK:
                if (enemyPath.Count <= 1)
                {
                    enemyState = EnemyState.INIT;
                    break;
                }

                transform.LookAt(enemyPath.Peek());
                transform.Translate(Vector3.forward * 1.6f * Time.deltaTime);
                if ((enemyPath.Peek() - transform.position).magnitude <= .1f)
                {
                    enemyPath.Dequeue();
                    transform.LookAt(enemyPath.Peek());
                }
                break;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
