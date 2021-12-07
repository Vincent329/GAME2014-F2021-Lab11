using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform Trigger;
    
    public Vector3 spawnPosition;
    public Vector3 triggerPosition;
     
    private Vector3 currentSpawnPosition;
    private Vector3  currentTriggerPosition;

    void Start()
    {
        spawnPosition = (spawnPoint.position);
        triggerPosition = (Trigger.position);
        
        currentSpawnPosition = spawnPosition;
        currentTriggerPosition = triggerPosition;
    }

    //// Update is called once per 
    //void Update()
    //{
    //    CheckIfPositionChanged();
    //}

    //public void CheckIfPositionChanged()
    //{
    //    if (spawnPosition != currentSpawnPosition)
    //    {
    //        spawnPoint.position = spawnPosition;
    //        currentSpawnPosition = spawnPosition;
    //    }
    //    if (triggerPosition != currentTriggerPosition)
    //    {
    //        Trigger.position = triggerPosition;
    //        currentTriggerPosition = triggerPosition;
    //    } 
    //}
}
