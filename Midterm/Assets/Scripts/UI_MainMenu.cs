using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_MainMenu : MonoBehaviour
{
    public Canvas settingsMenu;

    public void StartGame()
    {

    }

    public void LoadGame()
    {

    }

    public void Settings()
    {
        settingsMenu.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void QuitGame()
    {

    }
}
