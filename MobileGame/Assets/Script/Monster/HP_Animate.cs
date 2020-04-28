using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_Animate : MonoBehaviour {
	public Text text;
	public float min_alpha;
	public float Fade_sp;
	public float Move_sp;
	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		text.color -= new Color(0, 0, 0, Fade_sp);
		text.transform.Translate(new Vector3(0,Move_sp,0));
		if (text.color.a <= 0) {
			Destroy (this.gameObject, 0.2f);
		}
	}
}
