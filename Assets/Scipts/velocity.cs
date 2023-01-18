using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class velocity : MonoBehaviour
{

    public Rigidbody rigidbody;
    public float speed = 2;
    public float SpeedPlayerVectical = 3f;
    public GameObject playerGO;

   private SceneLoader _sceneLoader;

    private void Start()
    {
        _sceneLoader.GameStarted = true;
        StartCoroutine(SpeedLevel());
        _sceneLoader = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneLoader>();
    }
    public void Update()

    {
        
        if (Input.GetMouseButton(0))
        {
            rigidbody.velocity = new Vector3(speed , SpeedPlayerVectical, 0);
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


    public void EasyLevel() {SpeedPlayerVectical = 3f;}
    public void MediumLevel() {SpeedPlayerVectical = 4.5f; speed = 2.3f;}
    public void HardLevel() {SpeedPlayerVectical = 6f; speed = 2.6f;}


       private void OnTriggerEnter(Collider other)
    {  
          Debug.Log("you die");  
          
               
    }
}
