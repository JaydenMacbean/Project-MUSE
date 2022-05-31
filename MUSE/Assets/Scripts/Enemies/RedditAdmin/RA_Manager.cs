using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class RA_Manager : MonoBehaviour
{
    public RAState gameState;
    
    #region Variables Patrolling
    NavMeshAgent agent;

    [Header("Patrolling Settings")]
    public Transform[] waypoints;
    int waypointIndex;
    private Vector3 target;
    #endregion

    #region Variables SearchPlayer
    private bool isPerformingAction;
    SearchPlayer searchPlayer;

    [Header("Search Settings")]
    public float detectionRadius;
    public float minimumDAngle = -50;
    public float maximumDAngle = 50;
    #endregion

    void Awake()
    {
        searchPlayer = GetComponent<SearchPlayer>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        UpdateDestination();
    }

    void Update()
    {
        HandleCurrentAction();

        if (Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    #region Functions Patrolling
    public void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    public void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
    #endregion

    #region Functions SearchPlayer
    private void HandleCurrentAction()
    {
        if(searchPlayer.mainTarget == null)
        {
            searchPlayer.HandleDetection();
        }
    }
    #endregion
}
