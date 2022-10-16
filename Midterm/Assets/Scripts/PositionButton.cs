using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionButton : MonoBehaviour
{
    public Material TransparentMaterial;
    public Material SelectedMaterial;
    public bool isCorrectDistance;
    public float distanceToCamera;
    private Vector3 cameraPos;
    //in the editor this is what you would set as the object you wan't to change

    void OnDrawGizmos() 
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 8);
    }

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = TransparentMaterial;
        CameraPositioner.actualCameraPos = cameraPos;
    }

    void Update()
    {
        //distanceToCamera = gameObject.transform.position - CameraPositioner.actualCameraPos;
        distanceToCamera = Vector3.Distance(transform.position, cameraPos);
    }

    void OnMouseOver()
    {
        gameObject.GetComponent<MeshRenderer>().material = SelectedMaterial;
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<MeshRenderer>().material = TransparentMaterial;
    }

    private void OnMouseDown()
    {
        CameraPositioner.clickedPositioner = true;
        CameraPositioner.newCameraPos = new Vector3(gameObject.transform.position.x, 1, gameObject.transform.position.z);
    }
}