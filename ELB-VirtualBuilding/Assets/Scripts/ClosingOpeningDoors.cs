using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingOpeningDoors : MonoBehaviour {

	public Animator animator;

	public void Start()
	{
		animator = gameObject.GetComponent<Animator>();
	}
	public void OnTriggerEnter(Collider col)
	{
		if(animator.GetBool("isOpening"))
		{
			animator.SetBool("isOpening", false);
		}
		else
		{
			animator.SetBool("isOpening", true);
		}
		

	}
}
