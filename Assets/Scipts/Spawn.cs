using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Obstacle;
    public Transform player;

    float y;
    float d;
    
  
    void Start()
    {

        y = Random.Range(3.030f, 5.5f);
            d = player.position.x;
            float x = d + 8.2f;

            Instantiate(Obstacle);
            Obstacle.transform.position = new Vector3(x, y, -9.426793f);

        
    }
    
}

  
