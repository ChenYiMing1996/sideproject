using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_Thunder : Magic_bsae{
	public Magic_Thunder
	(int level = 1
		,float damage =90f
		,float CirticalDamage =1.4f
		,float CirticalRate =0.25f
		,float NormalRate =0.35f
		,float PropertyRate=0.65f
		,string Elememt="Thunder")
	{
		this.level = level;
		this.damage = damage;
		this.CirticalDamage = CirticalDamage;
		this.CirticalRate = CirticalRate;
		this.NormalRate = NormalRate;
		this.PropertyRate = PropertyRate;
		this.Elememt = Elememt;
		this.magicUpgrade=new MagicTypeAUpgrade();
	}
	void Start () {
		this.level = 1;
		this.damage = 90;
		this.CirticalDamage = 1.4f;
		this.CirticalRate = 0.25f;
		this.NormalRate = 0.35f;
		this.PropertyRate = 0.65f;
		this.Elememt = "Thunder";
		this.magic_hight = 65f;
		this.magicUpgrade=new MagicTypeAUpgrade();
	}

	// Update is called once per frame
	void Update () {

	}
}