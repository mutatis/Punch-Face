﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text text;

    void Update()
    {
        text.text = PlayerPrefs.GetInt("CurrentScore", 0) + " Cute Score";
    }
}