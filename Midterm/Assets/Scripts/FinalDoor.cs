using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    public FinalButton[] buttons = new FinalButton[4];
    public int missingButtons = 0;

    private void OnMouseDown()
    {
        if (buttons[0].WasPressed() && buttons[1].WasPressed() && buttons[2].WasPressed() && buttons[3].WasPressed())
        {
            //win code
        } 
        else
        {
            for(int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].WasPressed() == false)
                {
                    missingButtons++;
                }
            }
        }
    }
}
