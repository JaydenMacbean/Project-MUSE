using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RA_Manager : MonoBehaviour
{
    private bool isPerformingAction;
    SearchPlayer searchPlayer;
    public float detectionRadius;
    public float minimumDAngle = -50;
    public float maximumDAngle = 50;

    private void Awake()
    {
        searchPlayer = GetComponent<SearchPlayer>();
    }

    
    private void Update()
    {
        HandleCurrentAction();
    }

    private void HandleCurrentAction()
    {
        if(searchPlayer.mainTarget == null)
        {
            searchPlayer.HandleDetection();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red; //replace red with whatever color you prefer
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
        Vector3 fovLine1 = Quaternion.AngleAxis(maximumDAngle, transform.up) * transform.forward * detectionRadius;
        Vector3 fovLine2 = Quaternion.AngleAxis(minimumDAngle, transform.up) * transform.forward * detectionRadius;
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, fovLine1);
        Gizmos.DrawRay(transform.position, fovLine2);
    }
}
