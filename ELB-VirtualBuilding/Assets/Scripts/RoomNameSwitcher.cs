using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RoomNameSwitcher : MonoBehaviour {

	public TextMeshProUGUI text;
	public AudioSource speaker;
	public bool hasPlayed;
	public void Start()
	{
		text = GameObject.Find("RoomName").GetComponent<TextMeshProUGUI>();
	}
	public void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
			text.text = this.gameObject.name;

		if(!hasPlayed)
		{
			hasPlayed = true;
			speaker.Play();
		}
	}

	public void OnTriggerExit(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			text.text = "";
		}

		if(speaker.isPlaying)
		{
			speaker.Stop();
		}
	}

}
