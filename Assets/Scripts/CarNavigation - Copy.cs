using UnityEngine;
using UnityEngine.AI;
public class CarNavigation : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    Vector3 NextLocation;
    int destinationIndex = 0;
    NavMeshAgent myAgent;
    float speed;
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        NextLocation = waypoints[(destinationIndex++) % waypoints.Length].position;
        speed = Random.Range(5f, 10f);
    }
    void Update()
    {
        FollowwayPoints();
        //myAgent.speed = speed;
    }

    private void FollowwayPoints()
    {

        Vector3 directionToWayPoint = NextLocation - transform.position;
        Quaternion rotationToWaypoint = Quaternion.LookRotation(directionToWayPoint);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotationToWaypoint, 1 * Time.deltaTime);
        if (Vector3.Distance(transform.position, NextLocation) < myAgent.stoppingDistance)
            NextLocation = waypoints[(destinationIndex++) % waypoints.Length].position;
        // if (destinationIndex == waypoints.Length)
        //     rotationToWaypoint = Quaternion.identity;
        myAgent.SetDestination(NextLocation);
    }
}
