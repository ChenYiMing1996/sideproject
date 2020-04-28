using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_Wind : Magic_bsae{
	public Magic_Wind
	(int level = 1
		,float damage =120f
		,float CirticalDamage =1.5f
		,float CirticalRate =0.25f
		,float NormalRate =0.45f
		,float PropertyRate=0.55f
		,string Elememt="Wind")
	{
		this.level = level;
		this.damage = damage;
		this.CirticalDamage = CirticalDamage;
		this.CirticalRate = CirticalRate;
		this.NormalRate = NormalRate;
		this.PropertyRate = PropertyRate;
		this.Elememt = Elememt;
		this.magicUpgrade=new MagicTypeCUpgrade();
	}
	void Start () {
		this.level = 1;
		this.damage = 120f;
		this.CirticalDamage = 1.5f;
		this.CirticalRate = 0.25f;
		this.NormalRate = 0.45f;
		this.PropertyRate = 0.55f;
		this.Elememt = "Wind";
		this.magic_hight = 85f;
		this.magicUpgrade=new MagicTypeCUpgrade();
	}

	// Update is called once per frame
	void Update () {

	}
}