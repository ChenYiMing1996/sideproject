using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEvent : MonoBehaviour {

	public GameObject gbj;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void UP()
	{
		gbj.GetComponent<monster_base> ().MoveUP ();
	}
	public void DOWN()
	{
		gbj.GetComponent<monster_base> ().MoveDOWN ();
	}
	public void Left()
	{
		gbj.GetComponent<monster_base> ().MoveLeft ();
	}
	public void Right()
	{
		gbj.GetComponent<monster_base> ().MoveRight ();
	}
}
