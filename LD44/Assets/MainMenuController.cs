using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject creditMenu;
    public GameObject SettingsButton;

    public void playGame() {
        SceneManager.LoadScene("Hospital");
    }
 
    public void settings() {
        mainMenu.SetActive(false);
        SettingsButton.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void credits() {
        mainMenu.SetActive(false);
        SettingsButton.SetActive(false);
        creditMenu.SetActive(true);
    }

    public void back() {
        mainMenu.SetActive(true);
        SettingsButton.SetActive(true);
        creditMenu.SetActive(false);
        settingsMenu.SetActive(false);
    }
 
    public void exitGame() {
        Application.Quit();
    }
}
