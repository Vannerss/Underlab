using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    /*public float hSpeed = 2f;
    public float vSpeed = 2f;

    public float yaw = 0f;
    public float pitch = 0f;*/


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*yaw += hSpeed * Input.GetAxis("Mouse X");
        pitch -= hSpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;*/


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
