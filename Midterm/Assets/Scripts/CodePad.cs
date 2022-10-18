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
        
    }

    public void CheckCode()
    {
        if (code == correctCode)
        {
            Debug.Log("EsoTilin");
        }
    }

}
