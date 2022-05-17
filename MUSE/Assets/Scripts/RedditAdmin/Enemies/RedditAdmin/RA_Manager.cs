using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RA_Manager : MonoBehaviour
{
    private bool isPerformingAction;
    LocomotionManager locomotionManager;
    public float detectionRadius;

    private void Awake()
    {
        locomotionManager = GetComponent<LocomotionManager>();
    }

    
    private void Update()
    {
        
    }

    private void HandleCurrentAction()
    {
        if(locomotionManager)
        {
            
        }
    }
}
