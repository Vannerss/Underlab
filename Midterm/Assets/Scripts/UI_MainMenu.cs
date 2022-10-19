using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
    public Canvas settingsMenu;
    public GameObject mainMenu;
    public GameObject loadingInterface;
    public GameObject crossfade;
    public GameObject UI;
    public Image loadingProgressBar;

    List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void NewGame()
    {
        HideMenu();
        DataPersistenceManager.instance.NewGame();
        Time.timeScale = 1;
        crossfade.SetActive(true);
        UI.SetActive(true);
        //ShowLoadingScreen();
        //LoadScenes();
        //StartCoroutine(LoadingScreen());
    }

    public void LoadGame()
    {
        HideMenu();
        //ShowLoadingScreen();
        //LoadScenes();
        //StartCoroutine(LoadingScreen());
        DataPersistenceManager.instance.LoadGame();
        Time.timeScale = 1;
        crossfade.SetActive(true);
        UI.SetActive(true);
    }

    public void Settings()
    {
        HideMenu();
        settingsMenu.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void LoadScenes()
    {
        scenesToLoad.Add(SceneManager.LoadSceneAsync("Managers"));
        scenesToLoad.Add(SceneManager.LoadSceneAsync("Map", LoadSceneMode.Additive));
    }

    public void HideMenu()
    {
        mainMenu.SetActive(false);
    }

    public void ShowLoadingScreen()
    {
        loadingInterface.SetActive(true);
    }

    IEnumerator LoadingScreen()
    {
        float totalProgress = 0;
        for (int i = 0; i < scenesToLoad.Count; i++)
        {
            while (!scenesToLoad[i].isDone)
            {
                totalProgress += scenesToLoad[i].progress;
                loadingProgressBar.fillAmount = totalProgress / scenesToLoad.Count;
                yield return null;
            }
        }
    }
}
