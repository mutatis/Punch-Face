using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTheGame : MonoBehaviour
{
    public GameObject[] startGameEnable, startGameInstantiate;

    public void LetsGo()
    {
        for(int i = 0; i < startGameEnable.Length; i++)
        {
            startGameEnable[i].SetActive(true);
        }
        for (int i = 0; i < startGameInstantiate.Length; i++)
        {
            Instantiate(startGameInstantiate[i]);
        }
        Destroy(gameObject);
    }
}
