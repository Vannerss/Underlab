using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalButton : MonoBehaviour
{
    public bool pressed = false;
    public Material green;

    // Start is called before the first frame update

    public void OnMouseDown()
    {
        gameObject.GetComponent<MeshRenderer>().material = green;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
    }

    public bool WasPressed()
    {
        return pressed;
    }
}
