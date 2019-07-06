using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public Animator anim;

    public int minhaVida;

    int temp;

    void Update()
    {
        if(minhaVida > Camera.main.GetComponent<Manager>().vida && temp <= 0)
        {
            anim.SetTrigger("Tchau");
            temp++;
        }
    }

    public void Tchau()
    {
        Destroy(gameObject);
    }
}
