using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [Header("Movement Settings")]

    public GameObject[] waypoints;

    public float speed = 1.5f;

    public float arrivalDistance = 0.1f;
    private int _currentWaypointIndex = 0;

    private void Update()
    {
        if (waypoints == null || waypoints.Length == 0) return;

        float distanceToTarget = Vector3.Distance(transform.position, waypoints[_currentWaypointIndex].transform.position);

        if (distanceToTarget < arrivalDistance)
        {
            _currentWaypointIndex++;
            if (_currentWaypointIndex >= waypoints.Length)
            {
                _currentWaypointIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position,waypoints[_currentWaypointIndex].transform.position,speed * Time.deltaTime);
    }
}