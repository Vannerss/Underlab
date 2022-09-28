using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionButton : MonoBehaviour
{
    public Material TransparentMaterial;
    public Material SelectedMaterial;
    //in the editor this is what you would set as the object you wan't to change
    

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = TransparentMaterial;
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