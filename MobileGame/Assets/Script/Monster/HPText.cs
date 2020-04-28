using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPText : MonoBehaviour {
	static public string MyValue ;
	// Use this for initialization
	void Start () 
	{
		this.GetComponent<Text> ().text = MyValue;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
