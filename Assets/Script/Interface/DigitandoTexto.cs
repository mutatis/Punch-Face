using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitandoTexto : MonoBehaviour
{
    public Text text;

    public Animator[] anim;

    public GameObject start;

    string story;

    Coroutine lastRoutine = null;

    int countClick;

    void Start()
    {
        story = text.text;
        text.text = "";
        lastRoutine = StartCoroutine(TypeRight());
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0) && countClick == 0)
        {
            StopCoroutine(lastRoutine);
            text.text = story;
            countClick++;
        }
        else if(Input.GetMouseButtonDown(0))
        {
            for(int i = 0; i < anim.Length; i++)
            {
                anim[i].SetTrigger("Bye");
            }
        }
    }

    IEnumerator TypeRight()
    {
        foreach (char c in story)
        {
            text.text += c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void Bye ()
    {
        text.text = "";
        start.SetActive(true);
        Destroy(gameObject);
    }
}
