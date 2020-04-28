using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_Water  : Magic_bsae{
	public Magic_Water
	(int level = 1
		,float damage =80f
		,float CirticalDamage =1.5f
		,float CirticalRate =0.15f
		,float NormalRate =0.25f
		,float PropertyRate=0.75f
		,string Elememt="Water")
	{
		this.level = level;
		this.damage = damage;
		this.CirticalDamage = CirticalDamage;
		this.CirticalRate = CirticalRate;
		this.NormalRate = NormalRate;
		this.PropertyRate = PropertyRate;
		this.Elememt = Elememt;
		this.magicUpgrade=new MagicTypeBUpgrade();
	}
	void Start () {
		this.level = 1;
		this.damage = 80f;
		this.CirticalDamage = 1.5f;
		this.CirticalRate = 0.15f;
		this.NormalRate = 0.25f;
		this.PropertyRate = 0.75f;
		this.Elememt = "Water";
		this.magic_hight = 80f;
		this.magicUpgrade=new MagicTypeBUpgrade();
	}

	// Update is called once per frame
	void Update () {
	}
}