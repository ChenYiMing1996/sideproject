using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_blocktype : MonoBehaviour {
	string magic_name;
	public GameObject _eventsystem;
	// Use this for initialization
	void Start () {
		magic_name = this.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void click()
	{
		_eventsystem.GetComponent<damage_event> ().blocktype = magic_name;
	}

}
