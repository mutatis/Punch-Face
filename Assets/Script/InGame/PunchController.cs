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

    private void OnMouseDown()
    {
        anim.SetTrigger("Dead");
        int temp = PlayerPrefs.GetInt("CurrentScore", 0) + 10;
        PlayerPrefs.SetInt("CurrentScore", temp);
    }
}
