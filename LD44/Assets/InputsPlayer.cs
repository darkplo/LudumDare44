using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Input;

public class InputsPlayer : MonoBehaviour
{
	CharacterController2D charac2D;
	float horizontalMove = 0f;
	bool jump = false;
	public bool up=false, down=false;
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
		jump = up = down = false;
	}
	public void Move(InputAction.CallbackContext context)
	{
		Vector2 mv = context.ReadValue<Vector2>();
		if (mv.y > 0)
			up = true;
		else if(mv.y<0)
			down = true;
		horizontalMove = mv.x * Speed;
		anim.SetBool("isWalking", mv.x != 0);
		
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
}