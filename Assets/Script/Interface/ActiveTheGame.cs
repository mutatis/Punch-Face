using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTheGame : MonoBehaviour
{
    public GameObject[] startGame;

    public void LetsGo()
    {
        for(int i = 0; i < startGame.Length; i++)
        {
            startGame[i].SetActive(true);
        }
        Destroy(gameObject);
    }
}
