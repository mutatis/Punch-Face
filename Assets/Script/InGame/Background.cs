using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject limitLeft, limitRight;

    public float velX;

    void Update()
    {
        transform.Translate(velX, 0, 0);

        if(transform.position.x <= limitLeft.transform.position.x)
        {
            transform.position = new Vector3(limitRight.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
