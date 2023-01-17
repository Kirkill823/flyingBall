using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resp : MonoBehaviour
{
    public GameObject Obstacle;
    public Transform player;
    
    float d;
    float y;
    void OnTriggerEnter()
    {
        y = Random.Range(3.030f, 5.5f);

        d = player.position.x;
        float x = d + 8.2f;

        Instantiate(Obstacle);
        Obstacle.transform.position = new Vector3(x, y, -9.426793f);


    }

}
