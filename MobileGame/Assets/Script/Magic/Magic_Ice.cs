using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_Ice : Magic_bsae{
	public Magic_Ice
	(int level = 1
		,float damage =90f
		,float CirticalDamage =1.5f
		,float CirticalRate =0.15f
		,float NormalRate =0.3f
		,float PropertyRate=0.7f
		,string Elememt="Ice")
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
		this.damage = 90f;
		this.CirticalDamage = 1.5f;
		this.CirticalRate = 0.15f;
		this.NormalRate = 0.3f;
		this.PropertyRate = 0.7f;
		this.Elememt = "Ice";
		this.magic_hight = 95f;
		this.magicUpgrade=new MagicTypeBUpgrade();
	}

	// Update is called once per frame
	void Update () {

	}
}