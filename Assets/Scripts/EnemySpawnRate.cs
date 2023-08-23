using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnRate : MonoBehaviour
{
    public GameObject objectToEnableAfter10Seconds;
    public GameObject objectToEnableAfter30Seconds;
    public GameObject objectToEnableAfter60Seconds;

    private float timer = 0f;

    private void Update()
    {
        
        timer += Time.deltaTime;

        
        if (timer >= 10f && objectToEnableAfter10Seconds != null)
        {
            objectToEnableAfter10Seconds.SetActive(true);
            objectToEnableAfter10Seconds = null; 
        }

        
        if (timer >= 30f && objectToEnableAfter30Seconds != null)
        {
            objectToEnableAfter30Seconds.SetActive(true);
            objectToEnableAfter30Seconds = null; 
        }

        
        if (timer >= 60f && objectToEnableAfter60Seconds != null)
        {
            objectToEnableAfter60Seconds.SetActive(true);
            objectToEnableAfter60Seconds = null; 
        }
    }
}
