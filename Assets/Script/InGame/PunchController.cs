using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchController : MonoBehaviour
{
    public SpriteRenderer sprtRender;

    public Sprite punchSpecial;

    public GameObject pontuou;

    public Animator anim;

    public int pontos;

    public float dobroValue;

    int tipo = 0;

    private void Start()
    {
        float temp = Random.value;

        //10% de chance de chamar o soco q vale o dobro de pontos
        if(temp < dobroValue)
        {
            sprtRender.sprite = punchSpecial;
            tipo = 1;
        }
    }

    public void Finally()
    {
        Destroy(pontuou);
        Destroy(gameObject);
    }

    public void Dano()
    {
        Camera.main.GetComponent<Manager>().Dano();
    }

    private void OnMouseDown()
    {
        anim.SetTrigger("Dead");
        if (tipo == 0)
        {
            Camera.main.GetComponent<Manager>().Defesa(pontos, gameObject);
        }
        else if(tipo == 1)
        {
            Camera.main.GetComponent<Manager>().Defesa((pontos * 2), gameObject);
        }
    }
}
