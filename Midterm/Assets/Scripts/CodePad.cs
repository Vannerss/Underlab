using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CodePad : MonoBehaviour
{
    string code = null;
    int wordIndex = 0;
    string alpha;
    public Text codeDisplay = null;
    public string correctCode;
    public Animation openDoor;
    public GameObject mainUI;
    public GameObject codePad3D;

    public void WriteFunction(string codeSlot)
    {
        if (wordIndex < 4)
        {
            wordIndex++;
            code = code + codeSlot;
            codeDisplay.text = code;
        }
        
    }

    public void DeleteNumber()
    {
        if (wordIndex >= 1)
        {
            code = code.Substring(0, code.Length - 1);
            codeDisplay.text = codeDisplay.text.Substring(0, codeDisplay.text.Length - 1);
            wordIndex--;
        }
        else if (wordIndex == 0)
        {
            gameObject.SetActive(false);
            mainUI.SetActive(true);
        }



    }

    public void CheckCode()
    {
        if (code == correctCode)
        {
            mainUI.SetActive(true);
            codePad3D.GetComponent<BoxCollider>().enabled = false;
            openDoor.Play();
            gameObject.SetActive(false);
        }
    }

}
