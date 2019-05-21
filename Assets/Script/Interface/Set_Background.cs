using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_Background : MonoBehaviour
{

    public Sprite[] sprite;

    public Image image;

    int random;

    void Start()
    {
        random = Random.Range(0, sprite.Length);
        image.sprite = sprite[random];
    }
}
