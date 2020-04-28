using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anime_char : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void _in()
    {
        this.GetComponent<Animator>().SetBool("in", true);
        this.GetComponent<Animator>().SetBool("exit", false);
    }
    public void exit()
    {
        this.GetComponent<Animator>().SetBool("exit", true);
        this.GetComponent<Animator>().SetBool("in", false);
    }

}
