using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEnemyStateEvent : MonoBehaviour {
    EventBase myEvent;

    EnemyAI enemy;

    [SerializeField]
    EnemyAI.EnemyState newState = new EnemyAI.EnemyState();

	void Start () {
        myEvent = GetComponent<EventBase>();

        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyAI>();

        enemy.startState(newState);

        myEvent.setComplete();
	}
	
	
}
