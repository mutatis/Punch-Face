using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Animator piscaDano;

    public int pontuacao, vida;

    private void Start()
    {
        pontuacao = 0;
        vida = 3;
    }

    private void Update()
    {
        if(vida < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void Defesa()
    {
        pontuacao += 10;
    }

    public void Dano()
    {
        if (vida >= 0)
        {
            vida -= 1;
            piscaDano.SetTrigger("Dano");
        }
    }
}
