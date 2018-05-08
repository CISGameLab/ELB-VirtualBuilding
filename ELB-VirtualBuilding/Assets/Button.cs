using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public AudioSource audio;
	
	public void OnTriggerEnter(Collider collider)
	{
		if(!audio.isPlaying)
		{
			audio.Play();
		}
	}
	
}
