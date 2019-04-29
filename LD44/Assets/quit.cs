using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
    public GameObject image1;
    public void Gameover()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
