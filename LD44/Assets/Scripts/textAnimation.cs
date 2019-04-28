using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textAnimation : MonoBehaviour
{
    public float delay = 1;
    private float t_time = 0;
    
    private TextMeshProUGUI t_textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        t_textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        t_time += Time.deltaTime;
        if (t_time >= delay && t_time < delay*2) {
            t_textMeshPro.SetText("Click to continue.");
        }
        else if (t_time >= delay*2 && t_time < delay*3) {
            t_textMeshPro.SetText("Click to continue..");
        }
        else if (t_time >= delay * 3) {
            t_textMeshPro.SetText("Click to continue...");
            t_time = 0;
        }
    }
}
