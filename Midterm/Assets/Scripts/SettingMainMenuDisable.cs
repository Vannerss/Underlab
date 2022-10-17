using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMainMenuDisable : MonoBehaviour
{
    public Canvas MainMenu;
    public void ExitSettings()
    {
        MainMenu.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
