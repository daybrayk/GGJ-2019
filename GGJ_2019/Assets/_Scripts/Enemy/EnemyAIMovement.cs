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
    private List<Transform> tempLocation = new List<Transform>();
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

    //public static void Shuffle<T>(this IList<T> ts)
    //{
    //    var count = ts.Count;
    //    var last = count - 1;
    //    for (var i = 0; i < last; ++i)
    //    {
    //        var r = UnityEngine.Random.Range(i, count);
    //        var tmp = ts[i];
    //        ts[i] = ts[r];
    //        ts[r] = tmp;
    //    }
    //}

}
