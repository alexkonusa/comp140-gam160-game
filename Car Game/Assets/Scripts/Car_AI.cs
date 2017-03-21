using UnityEngine;
using System.Collections;

public class Car_AI : MonoBehaviour
{

    public Transform[] patrolPoints; //this is where we will store all of our patrol points
    NavMeshAgent navMeshAgent;

	// Use this for initialization
	void Start ()
    {
        //Getting our navmesh component
        navMeshAgent = GetComponent<NavMeshAgent>();

        GoToAPatrolPoint();
    }

    void Update()
    {

        //Check if we have reached our destination
        CheckIfPointWasReached();

    }

    void GoToAPatrolPoint()
    {

        navMeshAgent.speed = Random.Range(3.5f, 10f); // select a random speed from given numbers
        int Index = Random.Range(0, patrolPoints.Length); // choose a random patrol point
        navMeshAgent.destination = patrolPoints[Index].position; // set the destination to selected point

    }

    void CheckIfPointWasReached()
    {
        //If remaining distance between the agent and our point is less than 0.1f
        // start the whole process all over again
        if (navMeshAgent.remainingDistance < 0.1f)
        {

            GoToAPatrolPoint();

        }
    }

}
