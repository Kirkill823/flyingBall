using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class SceneLoader : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    
    public int score = 0;
    public bool IsDead = false;
    public bool GameStarted = false;    
    public float speed = 2;
    public float SpeedPlayerVectical = 3f;
    public Rigidbody rigidbody;
    public GameObject RestartScreen;


    private void Start()
    {
        GameStarted = true;
        StartCoroutine(SpeedLevel());
        StartCoroutine(AddScore());
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

    public int number
    {
        get => PlayerPrefs.GetInt("NumKey", 0);
        private set
        {
            PlayerPrefs.SetInt("NumKey", value);
            PlayerPrefs.Save();
        }
    }
       private void OnTriggerEnter(Collider other)
    {  
          Debug.Log("you die");
        IsDead = true;
        RestartScreen.SetActive(true);
        number++;
    }
 

    public void SceneLoad(int index)
    {
        SceneManager.LoadScene(index);
    }
  
    IEnumerator AddScore()
    {
        yield return new WaitForSecondsRealtime(1);

        if (!IsDead)
        {        
                score++;    
                scoreText.text = score.ToString();  
            
            StartCoroutine(AddScore());
        }
    }
}
