using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class velocity : MonoBehaviour
{

    public Rigidbody rigidbody;

    private float speed = 2;
    float SpeedPlayerVectical = 1;
    bool IsDead = false;

    public void Update()

    {

        if (Input.GetMouseButton(0))
        {
            rigidbody.velocity = new Vector3(speed , 1.7f, 0);
        }
        else
        {
            rigidbody.velocity = new Vector3(speed, -1, 0);
        }
    }

    IEnumerator SpeedLevel()
    {
        yield return new WaitForSecondsRealtime(15f);

        SpeedPlayerVectical = SpeedPlayerVectical + 0.5f;

        StartCoroutine(SpeedLevel());
    }

    public void StandartLevel() {SpeedPlayerVectical = 3f; }
    public void MediumLevel() {SpeedPlayerVectical = 4.5f; speed = speed * 1.3f; }
    public void MaximumLevel() {SpeedPlayerVectical = 6f; speed = speed * 1.6f; }

    private void OnTriggerEnter()
    {
        IsDead = true;
        Destroy(gameObject); 
        Debug.Log("you die");
    }
}
