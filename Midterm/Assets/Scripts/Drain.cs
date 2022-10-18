using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drain : MonoBehaviour
{
    public GameObject waterPlane;
    public GameObject plug;
    private void OnMouseDown()
    {
        plug.SetActive(false);
        this.gameObject.GetComponent<MeshCollider>().enabled = false;
        waterPlane.GetComponent<WaterLevelManager>().AddTime();
    }
}
