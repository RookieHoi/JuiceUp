using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesroySplash : MonoBehaviour
{
    private float timeLeft;
    
    void Start()
    {
        timeLeft = 30;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if ( timeLeft < 0 )
        {
            Destroy(gameObject);
        }
    }
}
