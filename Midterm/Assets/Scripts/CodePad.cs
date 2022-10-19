using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CodePad : MonoBehaviour, IDataPersistence
{
    [SerializeField] public string id;

    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    string code = null;
    int wordIndex = 0;
    public Text codeDisplay = null;
    public string correctCode;
    public Animation openDoor;
    public GameObject mainUI;
    public GameObject codePad3D;
    public GameObject codePadUI;
    public bool unlocked = false;
    
    public void LoadData(GameData data)
    {
        data.codelocksUnlocked.TryGetValue(id, out unlocked);
        if (unlocked)
        {
            Debug.Log("im under the water pls help me");
            codePad3D.GetComponent<BoxCollider>().enabled = false;
            openDoor.Play();
        }
    }

    public void SaveData(ref GameData data)
    {
        if (data.codelocksUnlocked.ContainsKey(id))
        {
            data.codelocksUnlocked.Remove(id);
        }
        data.codelocksUnlocked.Add(id, unlocked);
    }

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
            unlocked = true;
            mainUI.SetActive(true);
            codePad3D.GetComponent<BoxCollider>().enabled = false;
            openDoor.Play();
            codePadUI.SetActive(false);
        }
    }


}
