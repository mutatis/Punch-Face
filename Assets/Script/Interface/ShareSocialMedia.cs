using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareSocialMedia : MonoBehaviour
{
    public void ClickShare()
    {
        new NativeShare().SetSubject("Subject").SetText("Text").Share();
    }
}
