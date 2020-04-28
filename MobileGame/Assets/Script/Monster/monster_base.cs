using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monster_base : MonoBehaviour {
	float _Spirit;//精神值
	public float Spirit
	{
		get
		{
			return _Spirit;
		}
		set
		{
			switch((value<=-0)?1:(value>=120)?2:3)
			{

			case 1: 
				_Spirit=-0;
				break;
			case 2: 
				_Spirit=120;
				break;
			default:
				_Spirit=value;
				break;
			}
		}
	}
	float _HP;//hp
	public float HP
	{
		get
		{
			return _HP;
		}
		set
		{
			switch((value<=-0)?1:(value>=Max_HP)?2:3)
			{

			case 1: 
				_HP=0;
				break;
			case 2: 
				_HP=Max_HP;
				break;
			default:
				_HP=value;
				break;
			}
		}
	}
    protected float Max_HP;
	protected float Defense;
	protected string Element1;
	protected string Element2;
	Vector2 _Position;
	public float Position_x
	{
		get
		{
			return _Position.x;
		}
		set
		{
			switch((value<=1)?1:(value>=5)?2:3)
			{

			case 1: 
				_Position.x=1;
				break;
			case 2: 
				_Position.x=5;
				break;
			default:
				_Position.x = value;
				break;
			}
		}
	}
	public float Position_y
	{
		get
		{
			return _Position.y;
		}
		set
		{
			switch((value<=1)?1:(value>=9)?2:3)
			{

			case 1: 
				_Position.y=1;
				break;
			case 2: 
				_Position.y=9;
				break;
			default:
				_Position.y = value;
				break;
			}
		}
	}
	protected float Attribute_per = 1f;
	protected float MonsterHight;
	protected float Damaged;
	public GameObject my_text;
	//--------------------------------------------------------
	public monster_base setHP(float hp)
	{
		this.HP = hp;
		return this;
	}
	public float getHP()
	{
		return this.HP;
	}
	public monster_base HpCal(float value)
	{
		this.HP -= value;
		return this;
	}
	//--------------------------------------------------------
	public monster_base setSpirit(float Spirit)
	{
		this.Spirit = Spirit;
		return this;
	}
	public float getSpirit()
	{
		
		return this.Spirit;
	}
	public monster_base SpiritCal(float value)
	{
		this.Spirit -= value;
		return this;
	}
	//--------------------------------------------------------
	public monster_base setDefense(float Defense)
	{
		this.Defense = Defense;
		return this;
	}
	public float getDefense()
	{
		return this.Defense;
	}
	//--------------------------------------------------------
	public monster_base setMaxHP(float MaxHP)
	{
		this.Max_HP = MaxHP;
		return this;
	}
	public float getMaxHp()
	{
		return this.Max_HP;
	}
	//--------------------------------------------------------扣血
	public void Dead_Filter()
	{
		if (this.Damaged >= HP) 
		{
			text_int (-HP);
			HP -= HP;
			this.gameObject.transform.GetChild (1).GetComponent<HP> ().HPreduce (Max_HP, HP);
		} 
		else 
		{
			text_int (-this.Damaged);
			HP -= this.Damaged;
			this.gameObject.transform.GetChild (1).GetComponent<HP> ().HPreduce (Max_HP, HP);
		}
	}
	//--------------------------------------------------------爆擊函式
	public float critical_Filter(float Critical_rate,float Cirtical_damage)
	{
		if (critical_dec (Critical_rate) == true) {
			Debug.Log ("爆擊");
			return Cirtical_damage;
		} else {
			Debug.Log ("無爆擊");
			return 1.00f;
		}
	}
	public bool critical_dec(float Critical_rate)//爆擊判定
	{
		float random;
		random = Random.value;
		switch ((random <= Critical_rate && random>=0f) ? 1 : (random >= Critical_rate && random<=1f) ? 2 : 3)
		{
		case 1:
			return true;
			break;
		case 2:
			return false;
			break;
		default:
			Debug.Log ("BUG!!爆擊未知判定!!");
			return false;
			break;
		} 
	}
	//--------------------------------------------------------
	public float BK_Rate()
	{
		return 0f;
	}
	//--------------------------------------------------------受傷總式
	public void HP_reduce(float M_damage, float M_NormalRate, float M_PropertyRate, float M_Cirtical_damage, float M_Critical_rate, string M_property ,float BK_rate,float BK_damage,float Block_rate )//扣hp程式
	{
		Debug.Log ("傷害:"+M_damage);
		Debug.Log ("基傷分率:"+M_NormalRate);
		Debug.Log ("屬性傷害分率:"+M_PropertyRate);
		Debug.Log ("爆擊傷害倍率:"+M_Cirtical_damage);
		Debug.Log ("爆擊率:"+M_Critical_rate);
		Debug.Log ("屬性:"+M_property);
		Debug.Log ("場地加成率:"+BK_rate);
		Debug.Log ("場地加成傷害:"+BK_damage);
		Debug.Log ("範圍加成:"+Block_rate);
		Damaged = ((((M_damage * M_PropertyRate) + BK_damage) * (Attribute_per + BK_rate) + (M_damage * M_NormalRate - Defense)) * BK_rate * critical_Filter(M_Critical_rate,M_Cirtical_damage)*Block_rate);//計算出總傷害
		Invoke("Dead_Filter",0.3f);
		Debug.Log("受到"+Damaged+"點傷害");
	}
	//---------------------------------------------------------屬性傷害測定
	virtual public void attribute_Filter(string magic_attribute)
	{
		
	}
	//--------------------------------------------------------受傷數字
	public void text_string(string my_text)
	{
		HPText.MyValue = my_text;
		Instantiate (
			this.my_text,
			new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z), 
			this.transform.rotation, 
			GameObject.Find ("Canvas").transform
		);
	}
	public void text_int(float my_text)
	{
		HPText.MyValue = Mathf.Round (my_text).ToString ();
		Instantiate (
			this.my_text,
			new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z), 
			this.transform.rotation, 
			GameObject.Find ("Canvas").transform
		);
	}
	//--------------------------------------------------------移動
	public monster_base MoveUP()
	{
		this.Position_x += -1;
		this.Position_y += 0;
		GetCheckBoardPosition (new Vector2 (this.Position_x, this.Position_y));
		return this;
	}
	public monster_base MoveDOWN()
	{
		this.Position_x += 1;
		this.Position_y += 0;
		GetCheckBoardPosition (new Vector2 (this.Position_x, this.Position_y));
		return this;
	}
	public monster_base MoveLeft()
	{
		this.Position_x += 0;
		this.Position_y += -1;
		GetCheckBoardPosition (new Vector2 (this.Position_x, this.Position_y));
		return this;
	}
	public monster_base MoveRight()
	{
		this.Position_x += 0;
		this.Position_y += 1;
		GetCheckBoardPosition (new Vector2 (this.Position_x, this.Position_y));
		return this;
	}
	public void GetCheckBoardPosition(Vector2 vec)
	{
		for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length - 1; i++) {
			if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().getX() == vec.x)
			{
	 			if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().getY() == vec.y)
				{
					this.transform.position = 
					new Vector2 (GameObject.FindGameObjectsWithTag ("checkerboard") [i].transform.position.x,
							GameObject.FindGameObjectsWithTag ("checkerboard") [i].transform.position.y +
							this.GetComponent<RectTransform> ().rect.height * this.GetComponent<RectTransform> ().lossyScale.y / 2
							);
				}
			}
		}
	}
	//--------------------------------------------------------
	public monster_base setPosition(Vector2 Position)
	{
		this.Position_x = Position.x;
		this.Position_y = Position.y;
		return this;
	}
	public Vector2 getPosition()
	{
		return new Vector2 (this.Position_x, this.Position_y);
	}
	//--------------------------------------------------------
}
