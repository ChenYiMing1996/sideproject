
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage_event : MonoBehaviour {
	static public int[] arrange = new int[2]{ 50, 50 };
	static public int[,] c = new int[9, 2]{ { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 } };
	public string blocktype;
	public int block_value = 0;
	public float y;
	public float intervals;
	protected Magic_bsae Magic;
	public GameObject gameobject;
	public GameObject prefab;
	protected Vector2 vec;
	protected Dictionary<bool,GameObject> monsterlist;
	// Use this for initialization
	void Start () {
		gameobject = prefab;
	}

	// Update is called once per frame
	void Update () {
	}
	public void load_Magic(Magic_bsae Magic)
	{
		this.Magic = Magic;
	}
	public void load_blocktype(string str)
	{
		blocktype = str;
	}
	public void load_blockvalue(int value)
	{
		block_value = value;
	}
	public void find_gbj()
	{
		if (blocktype == "九宮格 (UnityEngine.Sprite)") {//九宮格型
			if (block_value == 9) {
				c [0, 0] = arrange [0] - 1;
				c [0, 1] = arrange [1] - 1;
				c [1, 0] = arrange [0] - 1;
				c [1, 1] = arrange [1];
				c [2, 0] = arrange [0];
				c [2, 1] = arrange [1] - 1;
				c [3, 0] = arrange [0] - 1;
				c [3, 1] = arrange [1] + 1;
				c [4, 0] = arrange [0];
				c [4, 1] = arrange [1];
				c [5, 0] = arrange [0] + 1;
				c [5, 1] = arrange [1] - 1;
				c [6, 0] = arrange [0];
				c [6, 1] = arrange [1] + 1;
				c [7, 0] = arrange [0] + 1;
				c [7, 1] = arrange [1];
				c [8, 0] = arrange [0] + 1;
				c [8, 1] = arrange [1] + 1;
			}
		}
		if (blocktype == "十字 (UnityEngine.Sprite)") {//十字型
			if (block_value == 9) {
				c [0, 0] = arrange [0] - 2;
				c [0, 1] = arrange [1];
				c [1, 0] = arrange [0] - 1;
				c [1, 1] = arrange [1];
				c [2, 0] = arrange [0];
				c [2, 1] = arrange [1] + 2;
				c [3, 0] = arrange [0];
				c [3, 1] = arrange [1] + 1;
				c [4, 0] = arrange [0];
				c [4, 1] = arrange [1];
				c [5, 0] = arrange [0];
				c [5, 1] = arrange [1] - 1;
				c [6, 0] = arrange [0];
				c [6, 1] = arrange [1] - 2;
				c [7, 0] = arrange [0] + 1;
				c [7, 1] = arrange [1];
				c [8, 0] = arrange [0] + 2;
				c [8, 1] = arrange [1];
			}
		}
		if (blocktype == "叉字 (UnityEngine.Sprite)") {//叉字型
			if (block_value == 9) {
				c [0, 0] = arrange [0] - 2;
				c [0, 1] = arrange [1] + 2;
				c [1, 0] = arrange [0] - 2;
				c [1, 1] = arrange [1] - 2;
				c [2, 0] = arrange [0] - 1;
				c [2, 1] = arrange [1] + 1;
				c [3, 0] = arrange [0] - 1;
				c [3, 1] = arrange [1] - 1;
				c [4, 0] = arrange [0];
				c [4, 1] = arrange [1];
				c [5, 0] = arrange [0] + 1;
				c [5, 1] = arrange [1] + 1;
				c [6, 0] = arrange [0] + 1;
				c [6, 1] = arrange [1] - 1;
				c [7, 0] = arrange [0] + 2;
				c [7, 1] = arrange [1] + 2;
				c [8, 0] = arrange [0] + 2;
				c [8, 1] = arrange [1] - 2;
			}
			if (block_value == 5) {
				c [0, 0] = arrange [0] - 1;
				c [0, 1] = arrange [1] + 1;
				c [1, 0] = arrange [0] - 1;
				c [1, 1] = arrange [1] - 1;
				c [2, 0] = arrange [0];
				c [2, 1] = arrange [1];
				c [3, 0] = arrange [0] + 1;
				c [3, 1] = arrange [1] + 1;
				c [4, 0] = arrange [0] + 1;
				c [4, 1] = arrange [1] - 1;
			}
		}
		if (blocktype == "橫線 (UnityEngine.Sprite)") {//直線型
			if (block_value == 5) {
				c [0, 0] = arrange [0];
				c [0, 1] = arrange [1] + 2;
				c [1, 0] = arrange [0];
				c [1, 1] = arrange [1] + 1;
				c [2, 0] = arrange [0];
				c [2, 1] = arrange [1];
				c [3, 0] = arrange [0];
				c [3, 1] = arrange [1] - 1;
				c [4, 0] = arrange [0];
				c [4, 1] = arrange [1] - 2;
			}
			if (block_value == 3) {
				c [0, 0] = arrange [0];
				c [0, 1] = arrange [1] + 1;
				c [1, 0] = arrange [0];
				c [1, 1] = arrange [1];
				c [2, 0] = arrange [0];
				c [2, 1] = arrange [1] - 1;
			}
		}
		if (blocktype == "直線 (UnityEngine.Sprite)") {//橫線型
			if (block_value == 5) {
				c [0, 0] = arrange [0] + 2;
				c [0, 1] = arrange [1];
				c [1, 0] = arrange [0] + 1;
				c [1, 1] = arrange [1];
				c [2, 0] = arrange [0];
				c [2, 1] = arrange [1];
				c [3, 0] = arrange [0] - 1;
				c [3, 1] = arrange [1];
				c [4, 0] = arrange [0] - 2;
				c [4, 1] = arrange [1];
			}
			if (block_value == 3) {
				c [0, 0] = arrange [0] + 1;
				c [0, 1] = arrange [1];
				c [1, 0] = arrange [0];
				c [1, 1] = arrange [1];
				c [2, 0] = arrange [0] - 1;
				c [2, 1] = arrange [1];
			}
		}
		if (blocktype == "斜線 (UnityEngine.Sprite)") {//斜線型
			if (block_value == 3) {
				c [0, 0] = arrange [0] - 1;
				c [0, 1] = arrange [1] + 1;
				c [1, 0] = arrange [0];
				c [1, 1] = arrange [1];
				c [2, 0] = arrange [0] + 1;
				c [2, 1] = arrange [1] - 1;
			}
		}
		StartCoroutine (find ());
	}

	IEnumerator find()
	{
		Instantiate (
			Magic.Animate2, 
			new Vector3 (683f, 384f, 0), 
			Magic.Animate2.transform.rotation, 
			GameObject.Find ("Canvas").transform
		);
		yield return new WaitForSeconds (0.9f);
		if (block_value >= 1) {
			for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length - 1; i++) {
				if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[0,0])
				{
					if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[0,1])
					{
						active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
						if (block_value == 1) {
							relive ();
						}
					}
				}
			}
			yield return new WaitForSeconds(intervals);
			if (block_value >= 2) {
				for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length - 1; i++) {
					if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[1,0])
					{
						if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[1,1])
						{
							active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
							if (block_value == 2) {
								relive ();
							}
						}
					}
				}
				yield return new WaitForSeconds(intervals);
				if (block_value >= 3) {
					for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length - 1; i++) {
						if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[2,0])
						{
							if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[2,1])
							{
								active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
								if (block_value == 3) {
									relive ();
								}
							}
						}
					}
					yield return new WaitForSeconds(intervals);
					if (block_value >= 4) {
						for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length - 1; i++) {
							if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[3,0])
							{
								if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[3,1])
								{
									active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
									if (block_value == 4) {
										relive ();
									}
								}
							}
						}
						yield return new WaitForSeconds(intervals);
						if (block_value >= 5) {
							for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length - 1; i++) {
								if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[4,0])
								{
									if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[4,1])
									{
										active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
										if (block_value == 5) {
											relive ();
										}
									}
								}
							}
							yield return new WaitForSeconds(intervals);
							if (block_value >= 6) {
								for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length - 1; i++) {
									if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[5,0])
									{
										if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[5,1])
										{
											active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
											if (block_value == 6) {
												relive ();
											}
										}
									}
								}
								yield return new WaitForSeconds(intervals);
								if (block_value >= 7) {
									for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length - 1; i++) {
										if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[6,0])
										{
											if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[6,1])
											{
												active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
												if (block_value == 7) {
													relive ();
												}
											}
										}
									}
									yield return new WaitForSeconds(intervals);
									if (block_value >= 8) {
										for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length - 1; i++) {
											if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[7,0])
											{
												if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[7,1])
												{
													active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
													if (block_value == 8) {
														relive ();
													}
												}
											}
										} 
										yield return new WaitForSeconds(intervals);
										if(block_value >= 9)
										{
											for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length - 1; i++) {
												if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[8,0])
												{
													if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[8,1])
													{
														active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
														if (block_value == 9) {
															relive ();
														}
													}
												}
											} 
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}
	 public void active(GameObject gbj)
	{
		Instantiate (
			Magic.Animate, 
			new Vector3 (gbj.transform.position.x, gbj.transform.position.y+Magic.getmagic_hight(), gbj.transform.position.z), 
			gbj.transform.rotation, 
			GameObject.Find ("Canvas").transform
		);
	    vec = new Vector2 (gbj.GetComponent<Checkerboard> ().getX (), gbj.GetComponent<Checkerboard> ().getY ());
		for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("monster").Length - 1; i++) 
		{
			if (GameObject.FindGameObjectsWithTag ("monster") [i].GetComponent<monster_base> ().getPosition () == vec) 
			{
				GameObject.FindGameObjectsWithTag ("monster") [i].GetComponent<monster_base> ().HP_reduce 
				(Magic.getlDamage ()
				, Magic.getNormalRate ()
				, Magic.getlPropertyRate ()
				, Magic.getlCirticalDamage ()
				, Magic.getCirticalRate ()
				, Magic.getElememt ()
				, 1f
				, 0f
				, 2.5f/block_value
				);
			}
		}
	}
	public void relive()
	{
		blocktype = null;
		block_value = 0;

	}
}

