using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animate_controll : MonoBehaviour {


	public Image upgrade;
	public Image page;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void t()
	{
		upgrade.GetComponent<Animator>().SetBool("Bool",true);
		Invoke ("t2",0.5f);
	}
	public void t2()
	{
		page.GetComponent<Animator>().SetBool("Bool",true);
	}
	public void f()
	{
		page.GetComponent<Animator>().SetBool("Bool",false);
		Invoke ("f2",1.2f);
	}
	public void f2()
	{
		upgrade.GetComponent<Animator>().SetBool("Bool",false);
	}
}
