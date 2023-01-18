using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    float n;
   public void Update()
    {
       
        
            n = player.position.x;
            float i = n + 1.339232f;
            transform.position = new Vector3(i, 4.44f, -18.9f);
       
     }
} 
