using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clipboards : MonoBehaviour
{
    public GameObject codetextUI;
    public GameObject gameUI;

    public void OnMouseDown()
    {
        gameUI.SetActive(false);
        codetextUI.SetActive(true);
    }
}
