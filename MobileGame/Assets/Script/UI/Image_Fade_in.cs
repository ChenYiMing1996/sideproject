using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Fade_in : MonoBehaviour
{

    public Image image;
    bool bt;
    public float min_alpha;
    public float Fade_sp;
    public bool ScriptDo;
    public bool start_do;
    // Use this for initialization
    void Start()
    {
        if(start_do==true)
        {
            Fade_in();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ScriptDo == true)
        {
			Fade_in();
			ScriptDo = false;
        }
        if (bt == true)
        {
            image.color -= new Color(0, 0, 0, Fade_sp);
        }
        if (image.color.a <= min_alpha)
        {
            bt = false;
        }
    }
    public void Fade_in()
    {
        bt = true;
    }


}
