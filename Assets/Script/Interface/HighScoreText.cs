using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreText : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text.text = "Super pontuação cute " + PlayerPrefs.GetInt("HighScore");
    }
}
