//Script creado por mrivanovichh con la ayuda de LiveDimensions muchas gracias eres un crack!!
//Script made by mrivanovichh with the help of LiveDimensions thanks a lot you rock man!!

using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class SwitchPortals : UdonSharpBehaviour
{
    int index = 0;
    public VRC_PortalMarker portal;
    public string[] portalIDS;
    public Text pag;

    public void Start()
    {
        pag.text = (index + 1).ToString();
        portal.roomId = portalIDS[index];

    }
    public void Next()
    {
        index += 1;
        if (index >= portalIDS.Length)
            index = 0;
        pag.text = (index + 1).ToString();

        portal.roomId = portalIDS[index];

    }

    public void Previous()
    {
        index -= 1;
        if (index < 0)
            index = portalIDS.Length - 1;
        pag.text = (index + 1).ToString();

        portal.roomId = portalIDS[index];

    }
}
