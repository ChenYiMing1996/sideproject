using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkerboard : MonoBehaviour {
	public int[] arrange = new int[2];
	string Element;
	float dis = 10f;
	protected monster_base monster;
	protected bool monsterEXI;

	//--------------------------------------------------------------------------------------
	void Start () {
	}
	void Update () {
		
	}
	//--------------------------------------------------------------------------------------
	public int getX()
	{
		return arrange[0];
	}
	public string getStringX()
	{
		return arrange[0].ToString();
	}
	public int getY()
	{
		return arrange[1];
	}
	public string getStringY()
	{
		return arrange[1].ToString();
	}
	//--------------------------------------------------------------------------------------
	public Vector2 getArrange()
	{
		return new Vector2(arrange [0], arrange [1]);
	}
	//--------------------------------------------------------------------------------------
	public Checkerboard setMonster(monster_base Monster)
	{
		this.monster = Monster;
		return this;
	}
	public Checkerboard clearMonster()
	{
		this.monster = null;
		return this;
	}
	public monster_base getMonster( )
	{
		return this.monster;
	}
	//--------------------------------------------------------------------------------------
	public void mouse_in()
	{
		mouse_in_event.arrange [0] = arrange [0];
		mouse_in_event.arrange [1] = arrange [1];
		GameObject.Find ("EventSystem").GetComponent<mouse_in_event> ().find_gbj ();
	}
	public void mouse_exit()
	{
		mouse_exit_event.arrange [0] = arrange [0];
		mouse_exit_event.arrange [1] = arrange [1];
		GameObject.Find ("EventSystem").GetComponent<mouse_exit_event> ().find_gbj ();
	}
	public void click()
	{
		damage_event.arrange [0] = arrange [0];
		damage_event.arrange [1] = arrange [1];
		GameObject.Find ("EventSystem").GetComponent<damage_event> ().find_gbj ();
	}
    public void _up()
	{
		this.transform.Translate (0,dis,0);
	}
	public void _return()
	{
		this.transform.Translate (0,-dis,0);
	}

}