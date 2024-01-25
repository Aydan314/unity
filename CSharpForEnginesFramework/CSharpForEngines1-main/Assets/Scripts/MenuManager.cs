using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject settingsMenu;

    private bool settingsShown = false;

    private void Start()
    {
        settingsMenu.SetActive(settingsShown);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OpenAndCloseSettingsPanel()
    {
        settingsShown = !settingsShown;
        settingsMenu.SetActive(settingsShown);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
