using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    public SceneLoader loader;
    public Text Text;

    private void Start()
    {
        Text.text = "try number: " + (loader.number + 1).ToString();
    }
}
