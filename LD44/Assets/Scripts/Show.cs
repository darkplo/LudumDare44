using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show : MonoBehaviour
{
	int score;
	int money;
	public int audimat;
	int n;
	public TMPro.TMP_Text scoreText;
	public Slider slider;
	Image im;
	public Gradient grad;
	// Start is called before the first frame update
	void Start()
    {
		score = money = 0;
		n = 1;
		audimat = 600;
		InvokeRepeating("DecreaseAudimat", 0, 1);
		im = slider.transform.GetChild(1).GetChild(0).GetComponent<Image>();
    }
	void DecreaseAudimat()
	{
		audimat -= 2;
		if (audimat == 0)
		{
			GameOver();
		}
		slider.value = audimat / 1000f;
		im.color = grad.Evaluate(slider.value);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
	public void AddScore()
	{
		score++;
		money += (audimat * n);
		audimat += 60;
		Invoke("Text", 1.5f);
		Invoke("GetCommandBack", 4f);
		FindObjectOfType<InputsManager>().enabled = false;
	}
	void Text()
	{
		scoreText.text = score + "/7\n" + money + "$";
	}
	void GetCommandBack()
	{
		FindObjectOfType<InputsManager>().enabled = true;
	}
	void GameOver()
	{
		Debug.Log("TAPERDU T NUL");
	}

}
