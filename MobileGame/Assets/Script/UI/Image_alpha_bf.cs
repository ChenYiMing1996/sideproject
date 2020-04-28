using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_alpha_bf : MonoBehaviour
{



    public Image image;
    public bool bt;
    public bool ct;
    public float max_alpha;
    public float min_alpha;
    public float speed_76persecond;
    public bool finish;
    static public bool ScriptDo;
    public bool start_do;
    // Use this for initialization
    void Start()
    {
        if (start_do == true)
        {
            alpha_bf();
        }
        if (ScriptDo == true)
        {
            alpha_bf();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ct == true)
        {
            if (image.color.a >= max_alpha)
            {
                bt = false;
            }
            if (image.color.a <= min_alpha)
            {
                bt = true;
            }
            if (bt == false)
            {
                image.color -= new Color(0, 0, 0, speed_76persecond);
            }
            if (bt == true)
            {
                image.color += new Color(0, 0, 0, speed_76persecond);
            }
        }
    }
    public void alpha_bf()
    {
        ct = true;
    }


}
