using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchController : MonoBehaviour
{
    public Animator anim;

    public void Finally()
    {
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        anim.SetTrigger("Dead");
        int temp = PlayerPrefs.GetInt("CurrentScore", 0) + 1;
        PlayerPrefs.SetInt("CurrentScore", temp);
    }
}
