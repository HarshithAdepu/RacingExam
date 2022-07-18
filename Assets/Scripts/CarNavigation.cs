using UnityEngine;
using UnityEngine.AI;
public class CarAI : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    Vector3 NextLocation;
    int destinationIndex = 0;
    NavMeshAgent myAgent;
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        NextLocation = waypoints[(destinationIndex++) % waypoints.Length].position;
    }
    void Update()
    {
        FollowWayPoints();
    }
    private void FollowWayPoints()
    {
        Vector3 directionToWayPoint = NextLocation - transform.position;
        Quaternion rotationToWaypoint = Quaternion.LookRotation(directionToWayPoint);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotationToWaypoint, 1 * Time.deltaTime);
        if (Vector3.Distance(transform.position, NextLocation) < 1f)
        {
            NextLocation = waypoints[(destinationIndex++) % waypoints.Length].position + new Vector3(Random.Range((float)-2, (float)2), Random.Range((float)-2, (float)2), 1);
        }
        myAgent.SetDestination(NextLocation);
    }
}
