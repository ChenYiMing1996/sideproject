using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_in_Bottom : MonoBehaviour
{

    public Image image;//主圖片
    public float Mov_Distance;
    public float image_scale_y;
    public float speed;//移動速度
    public float frame_persecond;
    Vector3 position;//暫存位置
    float distance;//移動距離
    float time;//移動時間間隔
    int count;//移動計數器
    public bool finish;
    static public bool ScriptDo;
    public bool start_do;

    void Start()
    {
        if (start_do == true)
        {
            go();
        }
    }
    void Update()
    {

        if (ScriptDo == true)
        {
            go();
        }
    }
    public void go()
    {
        position = image.transform.position;
        distance = Mov_Distance * image_scale_y;//求得並儲存距離值(無正負方向)
        time = distance / speed;//求得時間
        image.transform.Translate(0, -Mov_Distance * image_scale_y, 0);//移出畫面待機進入視線
        move_void();
        //      if (time < 2 || time > 0)
        //      {
        //            Debug.Log("來自" + image.ToString() + "的訊息,適中的速度,將進行" + Mathf.Ceil(time * frame_persecond) + "次移動");
        //      }
        //      else
        //      {
        //            Debug.Log("來自" + image.ToString() + "的訊息,將進行" + Mathf.Ceil(time * frame_persecond) + "次移動");
        //            Debug.Log("建議將速度調為" + distance / 1 + "pixel/s以減少遊戲負擔");
        //      }
        //      Debug.Log("呼叫總移動函式");
    }

    void move_void()//總移動函式
    {
        count = 0;
        InvokeRepeating("move_count", time / frame_persecond, time / frame_persecond);//呼叫判斷式
        //      Debug.Log("呼叫移動計數器函式");
    }

    void move_count()//移動計數器判斷用
    {
        count += 1;//計數器+1
        if (count > Mathf.Ceil(time * frame_persecond))   //做足呼叫次數終止呼叫
        {
            CancelInvoke("move_void");//終止呼叫
            CancelInvoke("move_count");//終止呼叫
            image.transform.position = position;//確保回歸座標
            count = 0;
            finish = true;
            //          Debug.Log("判斷滿足次數");
        }
        else
        {
            move();
            //          為滿足呼叫次數再次呼叫移動函式
            //          Debug.Log("未滿足次數再次呼叫移動函式");
        }
    }
    void move()//移動函式
    {
        image.transform.Translate(0, distance / (time * frame_persecond), 0);//每秒移動20次
        //      Debug.Log("移動");
    }


}