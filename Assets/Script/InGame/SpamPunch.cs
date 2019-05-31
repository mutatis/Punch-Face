using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpamPunch : MonoBehaviour
{
    public GameObject punch;

    public float time, changeTime, limitTime;

    public GameObject[] posX, posY;

    float tempPosX, tempPosY;

    GameObject temp;

    Coroutine lastRoutine = null, changeRoutine = null;

    void Start()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
        lastRoutine = StartCoroutine(Spam());
        changeRoutine = StartCoroutine(ChangeTime());
    }

    void Update()
    {

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
        if (changeTime >= limitTime)
        { 
            time -= 0.1f;
        }
        changeRoutine = StartCoroutine(ChangeTime());
    }
}
