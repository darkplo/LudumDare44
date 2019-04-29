using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public bool poisonned = false;
    public bool elevatorDead;
    public GameObject door_closed;
    public GameObject door_opened;
    public Sprite door_broken;
    public Sprite door_broken_open;
    float delay = 5;
	Show show;
	public Animator anim;
	SoundPlayer soundPlayer;
	InputsManager im;
	private int elevator;
    private bool elevatorRuned = false;
    public GameObject elevator_death;
    public float delay_elevator = 3f;
    private float t_time = 0f;


    // Start is called before the first frame update
    void Start()
    {
		elevator = 0;
		show = FindObjectOfType<Show>();
		soundPlayer = FindObjectOfType<SoundPlayer>();
		im = FindObjectOfType<InputsManager>();
    }

    // Update is called once per frame
    void Update()
    {
		if (poisonned)
		{
			delay -= Time.deltaTime;
			if (delay <= 0)
			{
				poisonned = false;
				Dead(dead.Poison);
			}

		}
        if (elevatorDead && !elevatorRuned)
        {
            door_closed.GetComponent<SpriteRenderer>().sprite = door_broken;
            door_opened.GetComponent<SpriteRenderer>().sprite = door_broken_open;
            elevator_death.SetActive(true);
            elevatorRuned = true;
        }
        if (elevator_death.activeInHierarchy)
        {
            t_time += Time.deltaTime;
            if (t_time >= delay_elevator)
            {
                elevator_death.SetActive(false);
                t_time = 0;
            }
        }
    }

	//0 Defib		OK
	//1 Poison		OK
	//2 Rayon X		OK
	//3 Perf		OK
	//4 Cape		OK
	//5 Ascenseur	
	//6 Lit			OK
	public void Dead(dead k)
	{
		Debug.Log(k);
		show.AddScore();
		anim.SetTrigger("Death");
		soundPlayer.PlayDead(k);
	}

	internal void Jump()
	{
		if (!im.canMove)
		{
			if (elevator == 40 && !elevatorDead)
			{
				elevatorDead = true;
				Dead(dead.Elevator);
			}
			else
				elevator++;
		}
		soundPlayer.PlayJump();
	}
}
public enum dead
{
	Defib,
	Poison,
	XRay,
	Tube,
	Cape,
	Elevator,
	Bed
}