using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    public GameObject title;

    public Animator anim;

    public void Click()
    {
        anim.SetTrigger("Bye");
    }

    public void Finish()
    {
        Destroy(title.gameObject);
    }
}
