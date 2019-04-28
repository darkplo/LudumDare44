using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Input;

public class InputsManager : MonoBehaviour
{
	CharacterController2D charac2D;
	float horizontalMove = 0f;
	bool jump = false;
	public bool p_up=false, p_down=false;
	public bool canMove = true;
	public bool interract = false;
	public float Speed = 40f;
	public Animator anim;

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
		float mv = context.ReadValue<float>();
		if (!canMove)
			mv = 0;
		horizontalMove = mv * Speed;
		anim.SetBool("isWalking", mv != 0);
		
	}
	public void Jump(InputAction.CallbackContext context)
	{
		jump = true;
	}
	public void Interract(InputAction.CallbackContext context)
	{
		if (context.performed && !context.started)
			interract = true;
	}

	public void Climb(InputAction.CallbackContext context)
	{
		if (context.performed && !context.started)
			p_up = true;
	}

	public void ClimbDown (InputAction.CallbackContext context)
	{
		if (context.performed && !context.started)
			p_down = true;
	}
}