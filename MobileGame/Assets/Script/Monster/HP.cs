using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {
	public float speed;
	protected float percent;
	protected bool Switch;
	public GameObject gameObject;

	// Use this for initialization
	void Start () {
		Switch = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Switch == true) {
			this.GetComponent<Image> ().fillAmount -= speed;
			if (this.GetComponent<Image> ().fillAmount <= percent) {
				Switch = false;
			}
		}
		if (this.GetComponent<Image> ().fillAmount == 0) {
			Destroy (gameObject, 0.5f);
		}
	}
	public void HPreduce(float MonsterHPMax, float MonsterHP)
	{
		percent = MonsterHP / MonsterHPMax;
		if (this.GetComponent<Image> ().fillAmount > percent) {
			Switch = true;
		}
	}
}
