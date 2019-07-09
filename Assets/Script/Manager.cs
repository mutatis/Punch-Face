using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject pontuou, intfInGame;

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
            if(PlayerPrefs.GetInt("HighScore") < pontuacao)
            {
                PlayerPrefs.SetInt("HighScore", pontuacao);
            }
            SceneManager.LoadScene("GameOver");
        }
    }

    public void Defesa(int pontos, GameObject punch)
    {
        GameObject obj = Instantiate(pontuou, transform.position, transform.rotation);
        obj.transform.SetParent(intfInGame.transform);
        obj.transform.position = punch.transform.position;
        obj.transform.localScale = punch.transform.localScale;
        obj.GetComponent<Text>().text = "+" + pontos;
        punch.GetComponent<PunchController>().pontuou = obj;
        pontuacao += pontos;
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
