using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePad3D : MonoBehaviour
{
    public GameObject codePadUI;
    public GameObject mainUI;

    // Start is called before the first frame update
    void Start()
    {
        codePadUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        codePadUI.SetActive(true);
        mainUI.SetActive(false);
    }
}
