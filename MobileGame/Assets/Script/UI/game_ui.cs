using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_ui : MonoBehaviour {
	public Image[] blocktype = new Image[3];
	public Sprite[] spite;
	int[] RndArr = new int[0];

	void Awake () {
		randon_blocktype ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void randon_blocktype()
	{
		int temp;
		int[] num = new int[spite.Length];
		RndArr = new int[spite.Length];
		for (int i = 0; i <= spite.Length-1; i++) {
			num [i] = i;
		}
		for (int j = 0, x = spite.Length; j <= spite.Length-1; j++,x--) {
			temp = Random.Range (0, x - 1);
			RndArr [j] = num [temp];
			num [temp] = num [x - 1];
		}
		for (int i = 0; i <= blocktype.Length - 1; i++) {
			blocktype [i].sprite = spite [RndArr [i]];
		}
	}
	public void click0()
	{
		GameObject.Find ("EventSystem").GetComponent<damage_event> ().load_blockvalue (int.Parse (spite [RndArr [0]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<mouse_in_event> ().load_blockvalue (int.Parse (spite [RndArr [0]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<mouse_exit_event> ().load_blockvalue (int.Parse (spite [RndArr [0]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<damage_event> ().load_blocktype (spite [RndArr [0]].ToString ().Split ('_') [2]);
		GameObject.Find ("EventSystem").GetComponent<mouse_in_event> ().load_blocktype (spite [RndArr [0]].ToString ().Split ('_') [2]);
		GameObject.Find ("EventSystem").GetComponent<mouse_exit_event> ().load_blocktype (spite [RndArr [0]].ToString ().Split ('_') [2]);		
	}
	public void click1()
	{
    	GameObject.Find ("EventSystem").GetComponent<damage_event> ().load_blockvalue (int.Parse (spite [RndArr [1]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<mouse_in_event> ().load_blockvalue (int.Parse (spite [RndArr [1]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<mouse_exit_event> ().load_blockvalue (int.Parse (spite [RndArr [1]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<damage_event> ().load_blocktype (spite [RndArr [1]].ToString ().Split ('_') [2]);
		GameObject.Find ("EventSystem").GetComponent<mouse_in_event> ().load_blocktype (spite [RndArr [1]].ToString ().Split ('_') [2]);
		GameObject.Find ("EventSystem").GetComponent<mouse_exit_event> ().load_blocktype (spite [RndArr [1]].ToString ().Split ('_') [2]);
	}
	public void click2()
	{
		GameObject.Find ("EventSystem").GetComponent<damage_event> ().load_blockvalue (int.Parse (spite [RndArr [2]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<mouse_in_event> ().load_blockvalue (int.Parse (spite [RndArr [2]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<mouse_exit_event> ().load_blockvalue (int.Parse (spite [RndArr [2]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<damage_event> ().load_blocktype (spite [RndArr [2]].ToString ().Split ('_') [2]);
		GameObject.Find ("EventSystem").GetComponent<mouse_in_event> ().load_blocktype (spite [RndArr [2]].ToString ().Split ('_') [2]);
		GameObject.Find ("EventSystem").GetComponent<mouse_exit_event> ().load_blocktype (spite [RndArr [2]].ToString ().Split ('_') [2]);
	}
	public void click3()
	{
		GameObject.Find ("EventSystem").GetComponent<damage_event> ().load_blockvalue (int.Parse (spite [RndArr [3]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<mouse_in_event> ().load_blockvalue (int.Parse (spite [RndArr [3]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<mouse_exit_event> ().load_blockvalue (int.Parse (spite [RndArr [3]].ToString ().Split ('_') [1]));
		GameObject.Find ("EventSystem").GetComponent<damage_event> ().load_blocktype (spite [RndArr [3]].ToString ().Split ('_') [2]);
		GameObject.Find ("EventSystem").GetComponent<mouse_in_event> ().load_blocktype (spite [RndArr [3]].ToString ().Split ('_') [2]);
		GameObject.Find ("EventSystem").GetComponent<mouse_exit_event> ().load_blocktype (spite [RndArr [3]].ToString ().Split ('_') [2]);
	}
}
