using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public Vector3 cameraPositon;
    public Vector3 cameraRotation;
    //Starting Values
    public GameData()
    {
        this.cameraPositon = new Vector3(-11.25f, 1.25f, -2.5f);
        this.cameraRotation = Vector3.zero;
    }

}
