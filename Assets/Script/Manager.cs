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

    public float tempoDeErro;

    public bool acerto = true;

    Coroutine acertouStopRoutine = null;

    private void Start()
    {
        pontuacao = 0;
        PlayerPrefs.SetInt("Pontuacao", pontuacao);
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
            PlayerPrefs.SetInt("MorteAD", PlayerPrefs.GetInt("MorteAD") + 1);
            SceneManager.LoadScene("GameOver");
        }
    }

    public void Defesa(int pontos, GameObject punch)
    {
        if (acertouStopRoutine != null)
        {
            StopCoroutine(acertouStopRoutine);
        }
        acerto = true;
        GameObject obj = Instantiate(pontuou, transform.position, transform.rotation);
        obj.transform.SetParent(intfInGame.transform);
        obj.transform.position = punch.transform.position;
        obj.transform.localScale = punch.transform.localScale;
        obj.GetComponent<Text>().text = "+" + pontos;
        punch.GetComponent<PunchController>().pontuou = obj;
        pontuacao += pontos;
        PlayerPrefs.SetInt("Pontuacao", pontuacao);
    }

    public void Dano()
    {
        if (vida >= 0)
        {
            vida -= 1;
            piscaDano.SetTrigger("Dano");
        }
    }

    public void Erro()
    {
        acerto = false;
        acertouStopRoutine = StartCoroutine(EsperaErrado());
    }

    IEnumerator EsperaErrado()
    {
        yield return new WaitForSeconds(tempoDeErro);
        acerto = true;        
    }
}