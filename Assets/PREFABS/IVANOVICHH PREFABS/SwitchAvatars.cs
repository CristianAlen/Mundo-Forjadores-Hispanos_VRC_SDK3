//Script creado por mrivanovichh con la ayuda de LiveDimensions muchas gracias eres un crack!!
//Script made by mrivanovichh with the help of LiveDimensions thanks a lot you rock man!!

using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;


public class SwitchAvatars : UdonSharpBehaviour
{
    public int index = 0;
    public VRC_AvatarPedestal avatar1;
    public VRC_AvatarPedestal avatar2;
    public VRC_AvatarPedestal avatar3;
    public VRC_AvatarPedestal avatar4;
    public VRC_AvatarPedestal avatar5;
    public VRC_AvatarPedestal avatar6;
    public VRC_AvatarPedestal avatar7;
    public VRC_AvatarPedestal avatar8;
    public VRC_AvatarPedestal avatar9;

    public Text pag;
    public string[] avatarsIds1;
    public string[] avatarsIds2;
    public string[] avatarsIds3;
    public string[] avatarsIds4;
    public string[] avatarsIds5;
    public string[] avatarsIds6;
    public string[] avatarsIds7;
    public string[] avatarsIds8;
    public string[] avatarsIds9;

    public void Start()
    {
        pag.text = (index + 1).ToString();
        avatar1.blueprintId = avatarsIds1[index];
        avatar2.blueprintId = avatarsIds2[index];
        avatar3.blueprintId = avatarsIds3[index];
        avatar4.blueprintId = avatarsIds4[index];
        avatar5.blueprintId = avatarsIds5[index];
        avatar6.blueprintId = avatarsIds6[index];
        avatar7.blueprintId = avatarsIds7[index];
        avatar8.blueprintId = avatarsIds8[index];
        avatar9.blueprintId = avatarsIds9[index];

    }


    public void Next()
    {
        index += 1;
        if (index >= avatarsIds1.Length)
            index = 0;

        pag.text = (index + 1).ToString();

        avatar1.blueprintId = avatarsIds1[index];
        avatar2.blueprintId = avatarsIds2[index];
        avatar3.blueprintId = avatarsIds3[index];
        avatar4.blueprintId = avatarsIds4[index];
        avatar5.blueprintId = avatarsIds5[index];
        avatar6.blueprintId = avatarsIds6[index];
        avatar7.blueprintId = avatarsIds7[index];
        avatar8.blueprintId = avatarsIds8[index];
        avatar9.blueprintId = avatarsIds9[index];

    }

    public void Previous()
    {
        index -= 1;
        if (index < 0)
            index = avatarsIds1.Length - 1;

        pag.text = (index + 1).ToString();

        avatar1.blueprintId = avatarsIds1[index];
        avatar2.blueprintId = avatarsIds2[index];
        avatar3.blueprintId = avatarsIds3[index];
        avatar4.blueprintId = avatarsIds4[index];
        avatar5.blueprintId = avatarsIds5[index];
        avatar6.blueprintId = avatarsIds6[index];
        avatar7.blueprintId = avatarsIds7[index];
        avatar8.blueprintId = avatarsIds8[index];
        avatar9.blueprintId = avatarsIds9[index];


    }

}
