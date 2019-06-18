using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitsSpam : MonoBehaviour
{
    public GameObject[] posX, posY;

    public GameObject spam;

    private void Start()
    {

        PlayerPrefs.SetInt("CurrentScore", 0);
    }

    public void Spam()
    {
        Instantiate(spam);
    }
}
