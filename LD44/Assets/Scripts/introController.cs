using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introController : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;

    public void onImage1() {
        image1.SetActive(false);
        image2.SetActive(true);
    }

    public void onImage2() {
        SceneManager.LoadScene("Hospital");
    }
}
