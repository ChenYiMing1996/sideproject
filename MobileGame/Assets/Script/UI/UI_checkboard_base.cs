using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_checkboard_base : MonoBehaviour {
	static public int[] arrange = new int[2]{ 50, 50 };
	static public int[,] c = new int[9, 2]{ { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 }, { 50, 50 } };
	public string blocktype;
	public float y;
	public int block_value = 0;
	public GameObject ui_animate;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
	}

	public void load_magic(GameObject gbj)
	{
		ui_animate = gbj;
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
		if(blocktype=="九宮格 (UnityEngine.Sprite)")//九宮格型
		{
			if(block_value==9)
			{
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
		if(blocktype=="十字 (UnityEngine.Sprite)")//十字型
		{
			if (block_value == 9) 
			{
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
		if(blocktype=="叉字 (UnityEngine.Sprite)")//叉字型
		{
			if (block_value == 9) 
			{
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
			if (block_value == 5) 
			{
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
		if(blocktype=="橫線 (UnityEngine.Sprite)")//直線型
		{
			if (block_value == 5) 
			{
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
			if (block_value == 3) 
			{
				c [0, 0] = arrange [0];
				c [0, 1] = arrange [1] + 1;
				c [1, 0] = arrange [0];
				c [1, 1] = arrange [1];
				c [2, 0] = arrange [0];
				c [2, 1] = arrange [1] - 1;
			}
		}
		if(blocktype=="直線 (UnityEngine.Sprite)")//橫線型
		{
			if (block_value == 5) 
			{
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
			if (block_value == 3) 
			{
				c [0, 0] = arrange [0] + 1;
				c [0, 1] = arrange [1];
				c [1, 0] = arrange [0];
				c [1, 1] = arrange [1];
				c [2, 0] = arrange [0] - 1;
				c [2, 1] = arrange [1];
			}
		}
		if(blocktype=="斜線 (UnityEngine.Sprite)")//斜線型
		{
			if(block_value==3)
			{
				c [0, 0] = arrange [0] - 1;
				c [0, 1] = arrange [1] + 1;
				c [1, 0] = arrange [0];
				c [1, 1] = arrange [1];
				c [2, 0] = arrange [0] + 1;
				c [2, 1] = arrange [1] - 1;
			}
		}

		for (int i = 0; i <= GameObject.FindGameObjectsWithTag ("checkerboard").Length-1; i++) 
		{
			if (block_value>=3) {
				if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[0,0])
				{
					if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[0,1])
					{
						active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
					}
				}
				if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[1,0])
				{
					if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[1,1])
					{
						active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
					}
				}
				if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[2,0])
				{
					if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[2,1])
					{
						active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
					}
				}
				if (block_value>=5) {

					if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[3,0])
					{
						if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[3,1])
						{
							active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
						}
					}
					if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[4,0])
					{
						if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[4,1])
						{
							active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
						}
					}
					if (block_value>=9) {
						if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[5,0])
						{
							if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[5,1])
							{
								active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
							}
						}
						if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[6,0])
						{
							if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[6,1])
							{
								active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
							}
						}
						if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[7,0])
						{
							if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[7,1])
							{
								active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
							}
						}
						if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [0] == c[8,0])
						{
							if(GameObject.FindGameObjectsWithTag ("checkerboard") [i].GetComponent<Checkerboard> ().arrange [1] ==c[8,1])
							{
								active( GameObject.FindGameObjectsWithTag ("checkerboard") [i]);
							}
						}
					}
				}
			}
			if(i == GameObject.FindGameObjectsWithTag ("checkerboard").Length-1)
			{
				relive ();
			}
		}

	}
	virtual public void active(GameObject gbj)
	{
		
	}
	virtual public void relive()
	{
		
	}

}
