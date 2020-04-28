using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_alpha_button : MonoBehaviour {

    public Image image;
    public float[] alpha;
    public bool start_do1;
    public bool start_do2;
    public bool start_do3;
    public bool start_do4;
    static public bool finish;
    static public bool ScriptDo1;
    static public bool ScriptDo2;
    static public bool ScriptDo3;
    static public bool ScriptDo4;


	// Use this for initialization
    void Start()
    {
        if (start_do1 == true)
        {
            AlphaToalpha1();
        }
        if (start_do2 == true)
        {
            AlphaToalpha2();
        }
        if (start_do3 == true)
        {
            AlphaToalpha3();
        }
        if (start_do4 == true)
        {
            AlphaToalpha4();
        }
        if (ScriptDo1 == true)
        {
            AlphaToalpha1();
        }
        if (ScriptDo2 == true)
        {
            AlphaToalpha2();
        }
        if (ScriptDo3 == true)
        {
            AlphaToalpha3();
        }
        if (ScriptDo4 == true)
        {
            AlphaToalpha4();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AlphaToalpha1()
    {
        if (alpha.Length >= 1)
        {
            image.color = new Vector4(image.color.r, image.color.g, image.color.b, alpha[0]);
        }
    }
    public void AlphaToalpha2()
    {
        if (alpha.Length >= 2)
        {
            image.color = new Vector4(image.color.r, image.color.g, image.color.b, alpha[1]);
        }
    }
    public void AlphaToalpha3()
    {
        if (alpha.Length >= 3)
        {
            image.color = new Vector4(image.color.r, image.color.g, image.color.b, alpha[2]);
        }
    }
    public void AlphaToalpha4()
    {
        if (alpha.Length >= 4)
        {
            image.color = new Vector4(image.color.r, image.color.g, image.color.b, alpha[3]);
        }
    }
}
