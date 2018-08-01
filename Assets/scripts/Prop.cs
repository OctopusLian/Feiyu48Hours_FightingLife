using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Prop: MonoBehaviour
{
    public Image generate;
    public Image image;
    public GameObject tag;
    public GameObject temp;
    public Transform panel;
    public GameObject[] prehab = new GameObject[3];
    public GameObject chizi;
    public GameObject fenbi;
    public GameObject moshuiping;
    public float intervalTime=3.0f;
    // Use this for initialization





    private void Awake()
    {


    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (intervalTime > 0.0f)
            intervalTime = intervalTime - Time.deltaTime;
        else{
            int index = Random.Range(0, 3);
            Vector2 pos = new Vector2(Random.Range(-4, 4), Random.Range(-4, 4));
            intervalTime = 3.0f;
            switch (index)
            {
                case 0: tag = Instantiate(chizi) as GameObject; break;
                case 1: tag = Instantiate(fenbi) as GameObject; break;
                case 2: tag = Instantiate(moshuiping) as GameObject; break;
                default:
                    break;
            }
            tag.transform.position = pos;
            Debug.Log("generate");
        }
    }



    public void SetUp()
    {

    }


}
