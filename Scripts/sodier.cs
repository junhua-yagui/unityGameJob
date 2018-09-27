using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sodier : MonoBehaviour {

    public NavMeshAgent agent;
    public people player;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        agent.speed = 2.5f;
        agent.SetDestination(player.transform.position);
	}
}
