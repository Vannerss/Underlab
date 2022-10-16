using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositioner : MonoBehaviour
{
    public Camera cam1;
    public Animator transition;
    public GameObject camPos1;
    public GameObject directionMenuUI;
    public static Vector3 newCameraPos;
    public static bool clickedPositioner;
    public static Vector3 actualCameraPos;

    // Update is called once per frame
    void Update()
    {
        actualCameraPos = cam1.transform.position;


        if (clickedPositioner == true)
        {
            ChangeCamPosition();
            clickedPositioner = false;
        }
        
    }
    public void ChangeCamPosition()
    {
        StartCoroutine(MoveCam());
    }

    IEnumerator MoveCam()
    {
        //play
        transition.SetTrigger("Start");
        //wait
        yield return new WaitForSeconds(1);
        //move cam
        transition.SetTrigger("End");
        cam1.transform.position = newCameraPos;

    }
    public void Forward()
    {
        ChangeCamPosition();
    }
}
