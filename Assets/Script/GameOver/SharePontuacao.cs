using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharePontuacao : MonoBehaviour
{
    public void Pontos()
    {
        new NativeShare().SetSubject("Subject").SetText("Eu sou um defensor da fofura, e com isso consegui " + PlayerPrefs.GetInt("Pontuacao") + " " +
            " CuteScores... Sim eu sou muito bom e fofo! LINK DO JOGO").Share();
        Debug.Log(PlayerPrefs.GetInt("Pontuacao"));
    }
}
