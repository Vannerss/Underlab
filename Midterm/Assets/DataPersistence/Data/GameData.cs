using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public Vector3 cameraPositon;
    public Vector3 cameraRotation;
    public Vector3 waterLevel;

    public SerializableDictionary<string, bool> drainsOpened;
    public SerializableDictionary<string, bool> codelocksUnlocked;
    public SerializableDictionary<string, bool> buttonsPressed;

    //Starting Values
    public GameData()
    {
        this.cameraPositon = new Vector3(-11.25f, 1.25f, -2.5f);
        this.cameraRotation = Vector3.zero;
        this.waterLevel = new Vector3(0, 0.5f, 0);

        this.drainsOpened = new SerializableDictionary<string, bool>();
        this.codelocksUnlocked = new SerializableDictionary<string, bool>();
        this.buttonsPressed = new SerializableDictionary<string, bool>();
    }

}
