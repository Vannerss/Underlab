using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableHighlight : MonoBehaviour
{
    private Color startcolor;
    private Renderer render;

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }
    void OnMouseEnter()
    {
        startcolor = render.material.color;
        render.material.color = Color.yellow;
    }
    void OnMouseExit()
    {
        render.material.color = startcolor;
    }
}
