using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareSocialMedia : MonoBehaviour
{
    public void ClickShare()
    {
        new NativeShare().SetSubject("Subject").SetText("Quando a fofura está em risco, só o poder do amor para salvar. Venha amar e proteger! Precisamos de você!" +
            " https://d26lpennugtm8s.cloudfront.net/stores/463/257/products/dc135_7001-be421f6286b37358ba15133039501078-1024-1024.jpg").Share();
    }
}
