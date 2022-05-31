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
}
