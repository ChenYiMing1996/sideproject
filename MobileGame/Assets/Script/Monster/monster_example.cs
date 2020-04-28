using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_example : MonoBehaviour {
	float _temperature = 0f;
	public float temperature//溫度值
	{
		get
		{
			return _temperature;
		}
		set
		{
			switch((value<=-50)?1:(value>=50)?2:3)
			{

			case 1: 
				_temperature=-50;
				break;
			case 2: 
				_temperature=50;
				break;
			default:
				_temperature=value;
				break;
			}
		}
	}
	float _spirit = 100f;//精神值
	public float spirit
	{
		get
		{
			return _spirit;
		}
		set
		{
			switch((value<=-0)?1:(value>=120)?2:3)
			{

			case 1: 
				_spirit=-0;
				break;
			case 2: 
				_spirit=120;
				break;
			default:
				_spirit=value;
				break;
			}
		}
	}
	float _HP;//精神值
	public float HP
	{
		get
		{
			return _HP;
		}
		set
		{
			switch((value<=0)?1:(value>=Max_HP)?2:3)
			{

			case 1: 
				_spirit=0;
				break;
			case 2: 
				_spirit=Max_HP;
				break;
			default:
				_spirit=value;
				break;
			}
		}
	}
	public float Max_HP;
	public float Defense;
	float Critical_per = 1.00f;
	float Attribute_per = 1.00f;
	public bool fire=false;
	public bool water=false;
	public bool wood=false;
	public bool thunder=false;
	public bool ice=false;
	void Start () {
		
	}
	void Update () {
		
	}
	public void AA()
	{

	}
	public void Dead_Filter(float damage)//扣血物件刪除
	{
		if (damage >= HP) 
		{
			HP -= HP;
			Destroy (this.gameObject);
		} 
		else 
		{
			HP -= damage;
		}
	}

	public void critical_Filter(float Critical_damage,float Critical_rate)//爆擊篩選器
	{
		if (critical_dec (Critical_rate) == true) {
			Critical_per = Critical_rate;
			Debug.Log ("爆擊");
		} else {
			Critical_per = 1.00f;
		}
	}

	bool critical_dec(float Critical_rate)//爆擊判定
	{
		float random;
		random = Random.value;
		switch ((random <= Critical_rate && random>=0f) ? 1 : (random >= Critical_rate && random<=1f) ? 2 : 3)
		{
		case 1:
			return false;
			break;
		case 2:
			return true;
			break;
		default:
			Debug.Log ("爆擊未知值判定");
			return false;
			break;
		}
	}	
	public void HP_reduce(float damage, float Normal_damageRate, float Property_damageRate, float Cirtical_damage, float Critical_rate, string property)//扣hp程式
	{
		float Normal_damage = Normal_damageRate;//屬性傷害分率
		float Property_damage = Property_damageRate;//真實傷害分率
		critical_Filter (Cirtical_damage,Critical_rate);//取得爆擊率並呼叫爆擊篩選器,更新爆擊傷害倍率
		attribute_Filter (property);//取得魔法屬性並呼叫屬性篩選器,更新屬性傷害倍率
		float total_damage;//總傷害
		total_damage = ((damage * Attribute_per * Property_damage) + (damage * Normal_damage - Defense));//計算出總傷害
		Dead_Filter (total_damage);//實作扣血與是否死亡判定

	}

//----------------------------------------------------------------------------------------------------------------------------------
	virtual public void attribute_Filter(string magic_attribute)//屬性傷害測定
	{
		switch((fire==true)?1:(water==true)?2:(wood==true)?3:(thunder==true)?4:(ice==true)?5:6)
		{
		case 1: //火屬性
			Debug.Log("火屬篩選通過");
			switch((water==true)?1:(wood==true)?2:(thunder==true)?3:(ice==true)?4:5)
			{

			case 1: //火,水屬性
				Debug.Log("火水雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 0.40f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 1.20f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.75f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.56f;
				}
				break;
			case 2: //火,木屬性
				Debug.Log("火木雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 1.20f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.75f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.40f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 0.60f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.91f;
				}
				break;
			case 3: //火,雷屬性
				Debug.Log("火雷雙屬篩選通過");
				if (magic_attribute == "fire") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute == "water") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute == "wood") {
					Attribute_per = 0.70f;
				}
				if (magic_attribute == "thunder") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute == "ice") {
					Attribute_per = 0.70f;
				}
				break;
			case 4:  //火,冰屬性
				Debug.Log("火冰雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 1.04f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 1.20f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.30f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 1.00f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.56f;
				}
				break;
			default://純火屬性
				Debug.Log("純火屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.50f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 1.00f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 1.30f;
				}
				break;
			}
			break;
		case 2: //水屬性
			Debug.Log("火屬篩選通過");
			switch((fire==true)?1:(wood==true)?2:(thunder==true)?3:(ice==true)?4:5)
			{

			case 1: //水,火屬性
				Debug.Log("水火雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 0.40f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 1.20f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.75f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.56f;
				}
				break;
			case 2: //水,木屬性
				Debug.Log("水木雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 0.65f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.40f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 1.2f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 0.6f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 1.04f;
				}
				break;
			case 3: //水,雷屬性
				Debug.Log("水雷雙屬篩選通過");
				if (magic_attribute == "fire") {
					Attribute_per = 0.50f;
				}
				if (magic_attribute == "water") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute == "wood") {
					Attribute_per = 0.65f;
				}
				if (magic_attribute == "thunder") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute == "ice") {
					Attribute_per = 0.80f;
				}
				break;
			case 4:  //水,冰屬性
				Debug.Log("水冰雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 0.65f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.64f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.90f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.64f;
				}
				break;
			default://純水屬性
				Debug.Log("純水屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 0.50f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.70f;
				}
				break;
			}
			break;
		case 3: //木屬性
			Debug.Log("木屬篩選通過");
			switch((fire==true)?1:(water==true)?2:(thunder==true)?3:(ice==true)?4:5)
			{

			case 1: //木,火屬性
				Debug.Log("木火雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 1.20f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.75f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.40f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 0.60f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.91f;
				}
				break;
			case 2: //木,水屬性
				Debug.Log("木水雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 0.75f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.40f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 1.20f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 0.90f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 1.04f;
				}
				break;
			case 3: //木,雷屬性
				Debug.Log("木雷雙屬篩選通過");
				if (magic_attribute == "fire") {
					Attribute_per = 1.5f;
				}
				if (magic_attribute == "water") {
					Attribute_per = 0.50f;
				}
				if (magic_attribute == "wood") {
					Attribute_per = 1.04f;
				}
				if (magic_attribute == "thunder") {
					Attribute_per = 0.48f;
				}
				if (magic_attribute == "ice") {
					Attribute_per = 1.30f;
				}
				break;
			case 4:  //木,冰屬性
				Debug.Log("木冰雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 1.95f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.40f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.56f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 0.60f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 1.04f;
				}
				break;
			default://純木屬性
				Debug.Log("純木屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.50f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 0.60f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 1.30f;
				}
				break;
			}
			break;
		case 4: //雷屬性
			Debug.Log("雷屬篩選通過");
			switch((fire==true)?1:(water==true)?2:(wood==true)?3:(ice==true)?4:5)
			{

			case 1: //雷,火屬性
				Debug.Log("雷火屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.65f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.70f;
				}
				break;
			case 2: //雷,水屬性
				Debug.Log("雷水屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 0.50f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 1.95f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 1.20f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.80f;
				}
				break;
			case 3: //雷,木屬性
				Debug.Log("雷木屬篩選通過");
				if (magic_attribute == "fire") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute == "water") {
					Attribute_per = 0.50f;
				}
				if (magic_attribute == "wood") {
					Attribute_per = 1.04f;
				}
				if (magic_attribute == "thunder") {
					Attribute_per = 0.48f;
				}
				if (magic_attribute == "ice") {
					Attribute_per = 1.30f;
				}
				break;
			case 4:  //雷,冰屬性
				Debug.Log("雷冰屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 1.30f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.78f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.80f;
				}
				break;
			default://純雷屬性
				Debug.Log("純雷屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 1.00f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 1.00f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 1.30f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 1.00f;
				}
				break;
			}
			break;
		case 5: //冰屬性
			Debug.Log("冰屬篩選通過");
			switch((fire==true)?1:(water==true)?2:(wood==true)?3:(thunder==true)?4:5)
			{

			case 1: //冰,火屬性
				Debug.Log("冰火雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 1.04f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 1.20f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.30f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 1.00f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.56f;
				}
				break;
			case 2: //冰,水屬性
				Debug.Log("冰水雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 0.75f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.64f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.90f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 1.50f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.64f;
				}
				break;
			case 3: //冰,木屬性
				Debug.Log("冰木雙屬篩選通過");
				if (magic_attribute == "fire") {
					Attribute_per = 1.95f;
				}
				if (magic_attribute == "water") {
					Attribute_per = 0.40f;
				}
				if (magic_attribute == "wood") {
					Attribute_per = 0.48f;
				}
				if (magic_attribute == "thunder") {
					Attribute_per = 0.60f;
				}
				if (magic_attribute == "ice") {
					Attribute_per = 1.04f;
				}
				break;
			case 4:  //冰,雷屬性
				Debug.Log("冰雷雙屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 1.30f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.78f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.80f;
				}
				break;
			default://純冰屬性
				Debug.Log("純冰屬篩選通過");
				if (magic_attribute=="fire") {
					Attribute_per = 1.30f;
				}
				if (magic_attribute=="water") {
					Attribute_per = 0.80f;
				}
				if (magic_attribute=="wood") {
					Attribute_per = 0.60f;
				}
				if (magic_attribute=="thunder") {
					Attribute_per = 1.00f;
				}
				if (magic_attribute=="ice") {
					Attribute_per = 0.80f;
				}
				break;
			}
			break;
		default:
			break;
		}
//----------------------------------------------------------------------------------------------------------------------------------

	}

}
