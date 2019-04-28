using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{

	public List<AudioClip> clipsPlayer;
	public List<AudioClip> clipsNar;
	public AudioSource sourcePlayer;
	public AudioSource sourceNarrator;
	// Start is called before the first frame update
	void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void PlayJump()
	{
		sourcePlayer.clip = clipsPlayer[7];
		sourcePlayer.Play();
	}

	internal void PlayDead(dead k)
	{
		sourceNarrator.clip = clipsNar[(int)k];
		sourceNarrator.Play();
		sourcePlayer.clip = clipsPlayer[(int)k];
		sourcePlayer.Play();
	}

	internal void getDefib()
	{
		sourceNarrator.clip = clipsNar[7];
		sourceNarrator.Play();
	}

	internal void PlayVaccine()
	{
		sourceNarrator.clip = clipsNar[8];
		sourceNarrator.Play();
	}

	internal void PlayElevator()
	{
		sourcePlayer.clip = clipsPlayer[8];
		sourcePlayer.Play();
	}
}
