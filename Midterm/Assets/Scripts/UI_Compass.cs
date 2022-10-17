using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Compass : MonoBehaviour
{
    public Camera cam;
    public Text text;

    private void Update()
    {
        switch(Mathf.Round(CameraBehaviour.actualCameraRot.y * 10.0f) * 0.1f)
         {
             case 0f:
                 text.text = "N";
                 break;
             case 0.7f:
                 //Debug.Log("I turned");
                 text.text = "E";
                 break;
             case -0.7f:
                 text.text = "W";
                 break;
             case 1f:
                 text.text = "S";
                //text.SetText("S");
                 break;
             default:
                 break;
         }
        //Debug.Log(Mathf.Round(CameraBehaviour.actualCameraRot.y * 10.0f) * 0.1f);
        
        /*if(CameraBehaviour.actualCameraRot.y == 0f)
        {
            text.text = "N";
        }
        if ((Mathf.Round(CameraBehaviour.actualCameraRot.y * 10.0f) * 0.1f) == 0.7f)
        {
            text.text = "E";
        }
        if ((Mathf.Round(CameraBehaviour.actualCameraRot.y * 10.0f) * 0.1f) == -0.7f)
        {
            text.text = "W";
        }
        if (CameraBehaviour.actualCameraRot.y == 1f)
        {
            text.text = "S";
        }*/

    }
}
