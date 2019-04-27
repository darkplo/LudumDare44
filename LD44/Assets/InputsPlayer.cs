﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Input;

public class InputsPlayer : MonoBehaviour
{
	CharacterController2D charac2D;
	float horizontalMove = 0f;
	bool jump = false;
	public bool p_up=false, p_down=false;
	public bool interract = false;
	public float Speed = 40f;

	private void Start()
	{
		charac2D = GetComponent<CharacterController2D>();
	}
	private void FixedUpdate()
	{
		charac2D.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}
	public void Move(InputAction.CallbackContext context)
	{
		Vector2 mv = context.ReadValue<Vector2>();
		horizontalMove = mv.x * Speed;
		
	}
	public void Jump(InputAction.CallbackContext context)
	{
		jump = true;
	}
	public void Interract(InputAction.CallbackContext context)
	{
		interract = !interract;
		Debug.Log("Hfiuods");
	}

	public void Climb(InputAction.CallbackContext context)
	{

	}

	public void ClimbDown (InputAction.CallbackContext context)
	{
		
	}
}