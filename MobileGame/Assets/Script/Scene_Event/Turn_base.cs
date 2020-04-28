using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn_base : MonoBehaviour {
	protected int Turn;
	protected bool Playerturn;
	public GameObject[] game_ui;
	public Text text;


	// Use this for initialization
	void Start () {
		Turn = 1;
		this.Playerturn = true;
		StartCoroutine (TurnStart());
	}

	// Update is called once per frame
	void Update () {
		
	}
	public int getTurn()
	{
		return this.Turn;
	}
	public bool getPlayturn()
	{
		return this.Playerturn;
	}
	public Turn_base TurnAdd()
	{
		this.Turn++;
		return this;
	}
	public Turn_base TurnClear()
	{
		this.Turn = 0;
		return this;
	}
	public Turn_base TurnChange()
	{
		if (Playerturn == true) {
			Playerturn = false;
			return this;
		} 
		else {
			Playerturn = true;
			return this;
		}
	}
	public void playerTurn()
	{
		TurnAdd ();
		for(int i =0;i<=game_ui.Length-1;i++)
		{
			if (game_ui [i].activeSelf == true) {
				game_ui [i].BroadcastMessage ("randon_blocktype");
			} 
			else {
				game_ui [i].SetActive (true);
				game_ui [i].BroadcastMessage ("randon_blocktype");
				game_ui [i].SetActive (false);
			}
		}
		text.GetComponent<Text> ().text = Turn.ToString ();
	}
	public void enemyTurn()
	{

	}
	public void TextChange()
	{
		
	}
	IEnumerator TurnStart()
	{
		yield return new WaitUntil (() => Turn >= 2);
		Debug.Log ("第二回合");
		for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("monster").Length - 1; i++) 
		{
			yield return new WaitForSeconds (0.3f);
			GameObject.FindGameObjectsWithTag ("monster") [i].GetComponent<monster_base> ().MoveLeft ();
		}
		yield return new WaitUntil (() => Turn >= 3);
		Debug.Log ("第三回合");
		for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("monster").Length - 1; i++) 
		{
			yield return new WaitForSeconds (0.3f);
			GameObject.FindGameObjectsWithTag ("monster") [i].GetComponent<monster_base> ().MoveLeft ();
		}
		yield return new WaitUntil (() => Turn >= 4);
		Debug.Log ("第四回合");
		for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("monster").Length - 1; i++) 
		{
			yield return new WaitForSeconds (0.3f);
			GameObject.FindGameObjectsWithTag ("monster") [i].GetComponent<monster_base> ().MoveLeft ();
		}
		yield return new WaitUntil (() => Turn >= 5);
		Debug.Log ("第五回合");
		for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("monster").Length - 1; i++) 
		{
			yield return new WaitForSeconds (0.3f);
			GameObject.FindGameObjectsWithTag ("monster") [i].GetComponent<monster_base> ().MoveLeft ();
		}
		yield return new WaitUntil (() => Turn >= 6);
		Debug.Log ("第六回合");
		for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("monster").Length - 1; i++) 
		{
			yield return new WaitForSeconds (0.3f);
			GameObject.FindGameObjectsWithTag ("monster") [i].GetComponent<monster_base> ().MoveLeft ();
		}
		yield return new WaitUntil (() => Turn >= 7);
		Debug.Log ("第七回合");
		for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("monster").Length - 1; i++) 
		{
			yield return new WaitForSeconds (0.3f);
			GameObject.FindGameObjectsWithTag ("monster") [i].GetComponent<monster_base> ().MoveLeft ();
		}
	}
}
