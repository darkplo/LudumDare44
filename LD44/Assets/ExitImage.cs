using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitImage : MonoBehaviour
{
    public GameObject image1;
    public void Gameover()
    {
        image1.SetActive(false);
    }
}
