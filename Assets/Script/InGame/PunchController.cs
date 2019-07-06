using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchController : MonoBehaviour
{
    public GameObject point;

    public Animator anim;

    public void Points()
    {
        point.SetActive(true);
    }

    public void Finally()
    {
        Destroy(gameObject);
    }

    public void Dano()
    {
        Camera.main.GetComponent<Manager>().Dano();
    }

    private void OnMouseDown()
    {
        anim.SetTrigger("Dead");
        Camera.main.GetComponent<Manager>().Defesa();
    }
}
