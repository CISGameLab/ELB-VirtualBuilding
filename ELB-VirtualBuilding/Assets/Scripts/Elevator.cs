using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {

	public int floorCount;
	public Vector3[] Levels;
	private int currentFloor;

	// Use this for initialization
	void Start ()
	{
		currentFloor = 1;
		this.gameObject.transform.position = Levels[0];
	}

	// Update is called once per frame
	void Update () 
	{
		
	}

	public void MoveElevator(int floor)
	{
		transform.position = Vector3.Lerp(Levels[currentFloor-1], Levels[floor-1], 0f);
	}
}
