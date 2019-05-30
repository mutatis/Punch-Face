using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    public GameObject[] menu;

    public GameObject texto;

    public Animator anim;

    public void Click()
    {
        anim.SetTrigger("Bye");
    }

    public void Finish()
    {
        texto.SetActive(true);
        for (int i = 0; i < menu.Length; i++)
        {
            Destroy(menu[i].gameObject);
        }
    }
}
