using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIMovement : AvatarFunctionality {

    [SerializeField]
    private Transform playerLocation;
    public bool playerInSight;

	// Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInSight == true)
        {
            ChasePlayer();
        }
        else
        {
            Patrol();
        }
	}

    public void ChasePlayer()
    {

    }

    private void Patrol()
    {

    }
}
