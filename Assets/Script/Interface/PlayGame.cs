using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    public GameObject title;

    public void Click()
    {
        Destroy(title.gameObject);
    }
}
