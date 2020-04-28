using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animate_trigger : MonoBehaviour {

	public GameObject obj;
	public GameObject obj2;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void active()
	{
		obj.GetComponent<Button> ().enabled = true;
		obj2.GetComponent<Button> ().enabled = true;
	}
}
