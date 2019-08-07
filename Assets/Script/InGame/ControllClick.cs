using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (Camera.main.GetComponent<Manager>().acerto)
        {
            Camera.main.GetComponent<Manager>().Erro();
        }
    }
}
