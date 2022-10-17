using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour, IDataPersistence
{
    public static Vector3 actualCameraPos;
    public static Vector3 actualCameraRot = Vector3.zero;

    public void LoadData(GameData data)
    {
        this.gameObject.transform.position = data.cameraPositon;
        this.gameObject.transform.eulerAngles = data.cameraRotation;
    }

    public void SaveData(ref GameData data)
    {
        data.cameraPositon = this.gameObject.transform.position;
        data.cameraRotation = this.gameObject.transform.eulerAngles;
    }

    void Update()
    {
        actualCameraPos = gameObject.transform.position;
        actualCameraRot.y = gameObject.transform.rotation.y;
    }

    public void Turnleft()
    {
        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y - 90, gameObject.transform.eulerAngles.z);
    }

    public void Turnright()
    {
        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y + 90, gameObject.transform.eulerAngles.z);
    }

}
