using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RoomNameSwitcher : MonoBehaviour {

	public TextMeshProUGUI text;

	public void Start()
	{
		text = GameObject.Find("RoomName").GetComponent<TextMeshProUGUI>();
	}
	public void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
			text.text = this.gameObject.name;
	}

	/*	public void OnTriggerExit(Collider col)
	{
		if(col.gameObject.tag == "Player")
			text.text = "";
	}
*/
}
