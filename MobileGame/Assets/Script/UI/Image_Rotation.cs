using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image_Rotation : MonoBehaviour {
    public float x_speed;
    public float y_speed;
    public float z_speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(x_speed, y_speed, z_speed);
	}
}
