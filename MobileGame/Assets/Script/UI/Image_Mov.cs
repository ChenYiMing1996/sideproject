using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Mov : MonoBehaviour
{

    public GameObject content;
    public Image[] image;
    public float image_width;
    float[] position_x;//
    int _count;//計算元
    public float count_second;//每幾秒輪下張圖
    public float min_movspeed;//最低移動速限
    public int count//保護_count值並限制只能存1~image.length
    {
        get
        {
            return _count;
        }
        set
        {
            switch ((value <= 0) ? 1 : (value >= image.Length - 1) ? 2 : 3)
            {

                case 1:
                    _count = 0;
                    break;
                case 2:
                    _count = image.Length - 1;
                    break;
                default:
                    _count = value;
                    break;
            }
        }
    }
    int _now_count;
    public int now_count//保護_now_count值並限制只能存1~image.length
    {
        get
        {
            return _now_count;
        }
        set
        {
            switch ((value <= 0) ? 1 : (value >= image.Length - 1) ? 2 : 3)
            {

                case 1:
                    _now_count = 0;
                    break;
                case 2:
                    _now_count = image.Length - 1;
                    break;
                default:
                    _now_count = value;
                    break;
            }
        }
    }

    void Start()
    {
        position_x = new float[image.Length];// image陣列元素量帶入position_x陣列元素量
        for (int i = 0; i <= image.Length - 1; i++)//為陣列position_x加入等距image_width並儲存
        {
            position_x[i] = content.transform.position.x + image_width * i;
        }
        now_count = 0;//預設當前now_count
        count = 0;//預設當前count
        StartCoroutine(per_time(count_second));//開啟每count_second秒自動跳下張的協程
    }

    void Update()
    {
        //		Debug.Log ("count:" + count);
        //		Debug.Log ("now_count:" + now_count);
        //		Debug.Log ("當前座標值:" + content.transform.position.x);
        //		Debug.Log ("預存position_x[" + now_count + "]的值:" + position_x [now_count]);
        _UI_Mov();
        Rev_UI_Mov();
    }
    void Rev_UI_Mov()
    {
        if (now_count < count)
        {
            if (-(content.transform.position.x - position_x[now_count]) / 20 <= -min_movspeed)
            {
                content.transform.position += new Vector3((position_x[now_count] - content.transform.position.x) / 20, 0, 0);
                Rev_mov_bound();
            }
            if (-(content.transform.position.x - position_x[now_count]) / 20 > -min_movspeed)
            {
                content.transform.position += new Vector3(-min_movspeed, 0, 0);
                Rev_mov_bound();
            }
        }
    }
    void Rev_mov_bound()//反mov回彈
    {
        if (content.transform.position.x < position_x[now_count])
        {
            if (count > now_count)
            {
                count -= 1;
            }
            content.transform.position = new Vector3(position_x[now_count], content.transform.position.y, content.transform.position.z);
        }
    }
    void _UI_Mov()
    {
        if (now_count > count)
        {
            if ((position_x[now_count] - content.transform.position.x) / 20 >= min_movspeed)
            {
                content.transform.position += new Vector3((position_x[now_count] - content.transform.position.x) / 20, 0, 0);
                mov_bound();
            }
            if ((position_x[now_count] - content.transform.position.x) / 20 < min_movspeed)
            {
                content.transform.position += new Vector3(min_movspeed, 0, 0);
                mov_bound();
            }
        }

    }
    void mov_bound()//正mov回彈
    {
        if (content.transform.position.x > position_x[now_count])
        {
            if (count < now_count)
            {
                count += 1;
            }
            content.transform.position = new Vector3(position_x[now_count], content.transform.position.y, content.transform.position.z);
        }
    }
    public void right_click()
    {
        now_count--;
    }
    public void left_click()
    {
        now_count++;
    }
    IEnumerator per_time(float speed)//開啟每count_second秒自動跳下張的協程
    {
        for (int i = 0; i < 500; i++)
        {
            yield return new WaitForSeconds(speed);
            now_count += 1;
        }
    }

}