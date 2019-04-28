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

    public GameObject background;
    public GameObject backgroundPlay;
    public GameObject backgroundCredits;
    public GameObject backgroundQuit;
    public GameObject backgroundBack;


    public void playGame() {
        SceneManager.LoadScene("Intro");
    }

    public void onPlayHover() {
        background.SetActive(false);
        backgroundPlay.SetActive(true);
    }

    public void OnPlayHoverLeave() {
        background.SetActive(true);
        backgroundPlay.SetActive(false);
    }

    public void onCreditsHover() {
        background.SetActive(false);
        backgroundCredits.SetActive(true);
    }

    public void OnCreditsHoverLeave() {
        background.SetActive(true);
        backgroundCredits.SetActive(false);
    }

    public void onQuitHover() {
        background.SetActive(false);
        backgroundQuit.SetActive(true);
    }

    public void OnQuitHoverLeave() {
        background.SetActive(true);
        backgroundQuit.SetActive(false);
    }
 
    public void settings() {
        mainMenu.SetActive(false);
        background.SetActive(false);
        SettingsButton.SetActive(false);
        settingsMenu.SetActive(true);
        backgroundBack.SetActive(true);
    }

    public void credits() {
        mainMenu.SetActive(false);
        background.SetActive(false);
        SettingsButton.SetActive(false);
        creditMenu.SetActive(true);
        backgroundBack.SetActive(true);
    }

    public void back() {
        mainMenu.SetActive(true);
        SettingsButton.SetActive(true);
        creditMenu.SetActive(false);
        settingsMenu.SetActive(false);
        backgroundBack.SetActive(false);
        backgroundCredits.SetActive(false);
        background.SetActive(true);
    }
 
    public void exitGame() {
        Application.Quit();
    }
}
