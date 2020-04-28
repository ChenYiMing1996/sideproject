using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_normal : monster_base {

	public monster_normal (
		float Spirit=100,
		float Max_HP=200,
		float HP=200,
		float Defense=10,
		string Element1="Fire",
		string Element2=null)
	{
		this.Spirit = Spirit;
		this.Max_HP = Max_HP;
		this.HP = HP;
		this.Defense = Defense;
		this.Element1 = Element1;
		this.Element2 = Element2;
	}
	// Use this for initialization
	void Start () {
		this.Spirit = 100;
		this.Max_HP = 200;
		this.HP = 200;
		this.Defense = 10;
		this.Element1 = "Fire";
		this.Element2 = null;
		this.Position_x = 5f;
		this.Position_y = 8f;
		this.MonsterHight = 430f;
	}
	
	// Update is called once per frame
	void Update () {
	 	
	}

}
