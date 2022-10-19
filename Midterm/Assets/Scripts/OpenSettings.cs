using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    public GameObject settingsUI;
    public GameObject gameUI;

    public void Settings()
    {
        settingsUI.SetActive(true);
        gameUI.SetActive(false);
        Time.timeScale = 0f;
    }
}
