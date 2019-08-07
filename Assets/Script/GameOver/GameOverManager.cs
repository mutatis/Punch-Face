using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class GameOverManager : MonoBehaviour
{
    void Start()
    {
        if(Advertisement.IsReady() && PlayerPrefs.GetInt("MorteAD") >= 3)
        {
            Advertisement.Show();
            PlayerPrefs.SetInt("MorteAD", 0);
        }
    }
}
