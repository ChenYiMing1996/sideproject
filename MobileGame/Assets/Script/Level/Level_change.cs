using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_change : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void load_main_scene()//讀取場景"main_scene"
    {
        Application.LoadLevel("main_scene");
    }
    public void load_gmae_scene()//讀取場景"game_scene"
    {
        Application.LoadLevel("game_scene");
    }
    public void load_start_scene()//讀取場景"start_scene"
    {
        Application.LoadLevel("start_scene");
    }
    public void load_shop_scene()//讀取場景"shop_scene"
    {
        Application.LoadLevel("shop_scene");
    }
    public void load_up_scene()//讀取場景"shop_scene"
    {
        Application.LoadLevel("up_scene");
    }

}