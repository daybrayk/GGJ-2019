using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(EnemyView))]
[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAIMovement : AvatarFunctionality {

    private GameObject player;
    private NavMeshAgent nma;

    [SerializeField]
    private Transform target;
    public bool playerInSight;
    private float eyeSightRadius;

    //public float speed;

    public List<Transform> patrolLocations = new List<Transform>();
    //private List<Transform> tempLocation = new List<Transform>();
    [SerializeField]
    private int patrolNumber;

    // Use this for initialization
    new protected void Start () {
        base.Start();
        player = GameObject.FindGameObjectWithTag("Player");
        patrolNumber = 0;
        nma = GetComponent<NavMeshAgent>();

        eyeSightRadius = GetComponent<EnemyView>().viewRadius;//Takes the eyesite from eyesight code attached to EnemyViewScript

        if(patrolLocations.Count <=0)
        {
            Debug.Log("No Patrol Locations Entered For " + name);
        }

        ShuffleList();
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
        target = player.transform;
        nma.SetDestination(target.position);

        float distanceBetweenTarget = Vector3.Distance(target.position, transform.position);
        if(distanceBetweenTarget > eyeSightRadius)
        {
            target = patrolLocations[patrolNumber];
            playerInSight = false;
            nma.SetDestination(target.position);
        }
    }

    private void Patrol()
    {
        if (target == null)
        {
            target = NewPatrolLocation();
        }
        else
        {
            float distanceBetweenTarget = Vector3.Distance(target.position, transform.position);
            //Debug.Log(distanceBetweenTarget);
            if (distanceBetweenTarget < 2)
            {
                target = NewPatrolLocation();
            }
        }
    }

    private Transform NewPatrolLocation()
    {
        Transform newDestination;

        if(patrolNumber >= patrolLocations.Count - 1)
        {
            ShuffleList();
            patrolNumber = 0;

        }
        else
        {
            patrolNumber++;
        }

        newDestination = patrolLocations[patrolNumber];

        nma.SetDestination(newDestination.position);

        return newDestination;
    }

    private void OnCollisionEnter(Collision c)
    {
        if(c.transform.tag == "Player")
        {
            //c.transform.GetComponent<PlayerController>().DoSomething();
            Debug.Log("RAPE");

        }
    }

    private void ShuffleList()
    {

        List<Transform> tempList = new List<Transform>();
        int initialCount = patrolLocations.Count;
        //int temp = inputList.Count;

        for(int i = 0; i < initialCount; i++)
        {
            int r = Random.Range(0, patrolLocations.Count - 1);
            Transform temp = patrolLocations[r];
            tempList.Add(temp);
            patrolLocations.RemoveAt(r);
            
        }
        patrolLocations = tempList;

    }

}
