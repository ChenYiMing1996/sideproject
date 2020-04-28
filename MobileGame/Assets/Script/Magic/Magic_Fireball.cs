using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_Fireball : Magic_bsae{
	public Magic_Fireball
	(int level = 1
		,float damage =100f
		,float CirticalDamage =1.5f
		,float CirticalRate =0.15f
		,float NormalRate =0.4f
		,float PropertyRate=0.6f
		,string Elememt="Fire"
		)
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
		this.damage = 100f;
		this.CirticalDamage = 1.5f;
		this.CirticalRate = 0.15f;
		this.NormalRate = 0.4f;
		this.PropertyRate = 0.6f;
		this.Elememt = "Fire";
		this.magic_hight = 85f;
		this.magicUpgrade=new MagicTypeAUpgrade();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
