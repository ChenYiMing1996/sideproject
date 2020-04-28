using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Fade_out : MonoBehaviour
{

    public Image image;
    bool bt;
    public float max_alpha;
    public float Fade_sp;
    public bool ScriptDo;
    public bool start_do;
    // Use this for initialization
    void Start()
    {
        if (start_do == true)
        {
            Fade_out();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ScriptDo == true)
        {
            Fade_out();
			ScriptDo = false;
        }
        if (bt == true)
        {
            image.color += new Color(0, 0, 0, Fade_sp);
        }
		if (image.color.a >= max_alpha)
		{
			bt = false;
		}
    }
    public void Fade_out()
    {
        bt = true;
    }


}
