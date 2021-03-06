﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_bsae : MonoBehaviour {
	protected int level;
	protected float damage;
	protected float CirticalDamage;
	protected float CirticalRate;
	protected float NormalRate;
	protected float PropertyRate;
	protected string Elememt;
	protected float magic_hight;
	protected MagicUpgrade magicUpgrade;
	public GameObject Animate;
	public GameObject Animate2;

	public Magic_bsae
	(int level = 1
		,float damage =0f
		,float CirticalDamage =0f
		,float CirticalRate =0f
		,float NormalRate =0f
		,float PropertyRate=0f
		,string Elememt=null)
	{
		this.level = level;
		this.damage = damage;
		this.CirticalDamage = CirticalDamage;
		this.CirticalRate = CirticalRate;
		this.NormalRate = NormalRate;
		this.PropertyRate = PropertyRate;
		this.Elememt = Elememt;
	}


	public Magic_bsae getinformation()
	{
		Debug.Log (this.level);
		Debug.Log (this.damage);
		Debug.Log (this.CirticalDamage);
		Debug.Log (this.CirticalRate);
		Debug.Log (this.NormalRate);
		Debug.Log (this.PropertyRate);
		Debug.Log (this.Elememt);
		Debug.Log (this.magicUpgrade);
		return this;
	}
	//--------------------------------------------------------
	public Magic_bsae setUpgradeRate(MagicUpgrade rate)
	{
		this.magicUpgrade = rate;
		return this;
	}
	//--------------------------------------------------------
	public Magic_bsae setLevel(int Level)
	{
		this.level = level;
		return this;
	}
	public int getlevel()
	{
		return this.level;
	}
	//--------------------------------------------------------
	public Magic_bsae setDamage(int level)
	{
		this.damage = magicUpgrade.getDamage (level);
		return this;
	}
	public float getlDamage()
	{
		return this.damage;
	}
	//--------------------------------------------------------
	public Magic_bsae setCirticalDamage(float CirticalDamage)
	{
		this.CirticalDamage = CirticalDamage;
		return this;
	}
	public float getlCirticalDamage()
	{
		return this.CirticalDamage;
	} 
	//--------------------------------------------------------
	public Magic_bsae setCirticalRate(float CirticalRate)
	{
		switch((CirticalRate<=0)?1:(CirticalRate>=0.95)?2:3)
		{

		case 1: 
			this.CirticalRate = 0f;
			break;
		case 2: 
			this.CirticalRate = 0.95f;
			break;
		default:
			this.CirticalRate=CirticalRate;
			break;
		}
		return this;
	}
	public float getCirticalRate()
	{
		return this.CirticalRate;
	}
	//--------------------------------------------------------
	public Magic_bsae setNormalRate(float NormalRate)
	{
		this.NormalRate = NormalRate;
		return this;
	}
	public float getNormalRate()
	{
		return this.NormalRate;
	} 
	//--------------------------------------------------------
	public Magic_bsae setPropertyRate(float PropertyRate)
	{
		this.PropertyRate = PropertyRate;
		return this;
	}
	public float getlPropertyRate()
	{
		return this.PropertyRate;
	} 
	//--------------------------------------------------------
	public Magic_bsae setElememt(string Elememt)
	{
		this.Elememt = Elememt;
		return this;
	}
	public string getElememt()
	{
		return this.Elememt;
	}
	//--------------------------------------------------------
	public Magic_bsae setAnimate(GameObject Animate)
	{
		this.Animate = Animate;
		return this;
	}
	public GameObject getAnimate()
	{
		return this.Animate;
	}
	//--------------------------------------------------------
	public Magic_bsae setmagic_hight(float magic_hight)
	{
		this.magic_hight = magic_hight;
		return this;
	}
	public float getmagic_hight()
	{
		return this.magic_hight;
	} 
}

abstract public class MagicUpgrade
{
	abstract public float getDamage(int level);
}
public class MagicTypeAUpgrade : MagicUpgrade //早熟型
{
	protected Dictionary<int ,float> UpgradeList; 
	public MagicTypeAUpgrade()
	{
		this.UpgradeList = new Dictionary<int ,float> ();
		this.UpgradeList.Add (1, 32f);
		this.UpgradeList.Add (2, 43f);
		this.UpgradeList.Add (3, 52f);
		this.UpgradeList.Add (4, 60f);
		this.UpgradeList.Add (5, 66f);
		this.UpgradeList.Add (6, 71f);
		this.UpgradeList.Add (7, 76f);
	}
	override public float getDamage(int level)
	{
		return UpgradeList[level];
	}
}
public class MagicTypeBUpgrade : MagicUpgrade //平衡型
{
	protected Dictionary<int ,float> UpgradeList;
	public MagicTypeBUpgrade()
	{
		this.UpgradeList = new Dictionary<int ,float> ();
		this.UpgradeList.Add (1, 25f);
		this.UpgradeList.Add (2, 34f);
		this.UpgradeList.Add (3, 44f);
		this.UpgradeList.Add (4, 55f);
		this.UpgradeList.Add (5, 66f);
		this.UpgradeList.Add (6, 74f);
		this.UpgradeList.Add (7, 82f);
	}
	override public float getDamage(int level)
	{
		return UpgradeList[level];
	}
}
public class MagicTypeCUpgrade : MagicUpgrade //後期型
{
	protected Dictionary<int ,float> UpgradeList;
	public MagicTypeCUpgrade()
	{
		this.UpgradeList = new Dictionary<int ,float> ();
		this.UpgradeList.Add (1, 27f);
		this.UpgradeList.Add (2, 32f);
		this.UpgradeList.Add (3, 39f);
		this.UpgradeList.Add (4, 47f);
		this.UpgradeList.Add (5, 59f);
		this.UpgradeList.Add (6, 72f);
		this.UpgradeList.Add (7, 88f);
	}
	override public float getDamage(int level)
	{
		return UpgradeList[level];
	}
}
