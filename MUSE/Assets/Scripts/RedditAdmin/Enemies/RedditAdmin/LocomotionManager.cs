using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionManager : MonoBehaviour
{
    RA_Manager enemyManager;
    private LayerMask detectionLayer;
    private GameObject P1;

    
    private void Awake()
    {
        enemyManager = GetComponent<RA_Manager>();
        P1 = GameObject.Find("Player");
    }

    private void Update()
    {
        
    }

    private void HandleDetection()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, enemyManager.detectionRadius, detectionLayer);
        
        for(int i = 0; i < colliders.Length; i++)
        {

            Vector3 targetDirection = P1.transform.position - transform.position;
            float viewableAngle = Vector3.Angle(targetDirection, transform.forward);
        }
    }
}
