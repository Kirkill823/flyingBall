using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene0load : MonoBehaviour
{
    void Awake()
    {
        SceneManager.LoadScene(0);

        Destroy(gameObject);
    }
}
