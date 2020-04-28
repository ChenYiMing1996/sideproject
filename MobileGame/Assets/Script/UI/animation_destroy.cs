using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_destroy : MonoBehaviour {

	public float s;
	// Use this for initialization
	void Start () {
		GameObject.Destroy (this.gameObject, s);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
