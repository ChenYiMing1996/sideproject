using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_change : MonoBehaviour
{
    public Image[] image;
    public Sprite[] oldtext;
    public Sprite[] newtext;
    int count = 0;
    public bool finish;
    static public bool ScriptDo;
    public bool start_do;

    void Start()
    {
        if (start_do == true)
        {
            update();
        }
    }

    void Update()
    {
        if (ScriptDo == true)
        {
            update();
            ScriptDo = false;
        }
    }
    public void update()
    {
        for (int i = 0; i >= 0; i++)
        {
            if (count == i)
            {

                image[i].sprite = newtext[i];
            }

        }
    }
}