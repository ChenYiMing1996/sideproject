using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monster_generator : MonoBehaviour
{

    public Image[] monster;
    public Vector3[] pivot;
    public float[] wait_time;

    // Use this for initialization
    void Start()
    {
        Invoke("monster_create", 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void monster_create()
    {
        StartCoroutine("monster_ie");

    }
    IEnumerator monster_ie()
    {
        //
        for (int a = 0; a < monster.Length; a++)
        {
            Instantiate(monster[a], monster[a].transform.position, monster[a].transform.rotation);
            Invoke("SetCanvas", 0f);
            yield return new WaitForSeconds(wait_time[a]);
        }

    }
    void SetCanvas()
    {

        for (int b = 0; b < GameObject.FindGameObjectsWithTag("Monster01").Length; b++)
        {
            GameObject.FindGameObjectsWithTag("Monster01")[b].transform.SetParent(GameObject.Find("Canvas_monster").transform);
            GameObject.FindGameObjectsWithTag("Monster01")[b].transform.position = pivot[b];
        }

    }



}