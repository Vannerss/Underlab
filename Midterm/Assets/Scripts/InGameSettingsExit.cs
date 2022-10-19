using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameSettingsExit : MonoBehaviour
{
    public GameObject gameUI;

    public void Exit()
    {
        Time.timeScale = 1f;
        gameUI.SetActive(false);
        this.gameObject.SetActive(false);
    }
}