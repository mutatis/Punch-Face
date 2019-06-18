using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpamPunch : MonoBehaviour
{
    public GameObject punch;

    public float time, changeTime, limitTime;

    GameObject[] posX, posY;

    float tempPosX, tempPosY;

    int tempSpam;

    GameObject temp;

    Coroutine lastRoutine = null, changeRoutine = null;

    void Start()
    {
        posX = Camera.main.GetComponent<LimitsSpam>().posX;
        posY = Camera.main.GetComponent<LimitsSpam>().posY;
        lastRoutine = StartCoroutine(Spam());
        changeRoutine = StartCoroutine(ChangeTime());
        Debug.Log("CUUUU");
    }

    IEnumerator Spam()
    {
        yield return new WaitForSeconds(time);
        tempPosX = Random.Range(posX[0].transform.position.x, posX[1].transform.position.x);
        tempPosY = Random.Range(posY[0].transform.position.y, posY[1].transform.position.y);
        temp = Instantiate(punch, new Vector3(tempPosX, tempPosY, 0), Quaternion.identity);
        lastRoutine = StartCoroutine(Spam());
    }


    IEnumerator ChangeTime()
    {
        yield return new WaitForSeconds(changeTime);
        if (time >= limitTime && tempSpam == 0)
        { 
            time -= 0.1f;
        }
        else if(time < limitTime && tempSpam == 0)
        {
            Camera.main.GetComponent<LimitsSpam>().Spam();
            tempSpam = 1;
        }
        changeRoutine = StartCoroutine(ChangeTime());
    }
}
