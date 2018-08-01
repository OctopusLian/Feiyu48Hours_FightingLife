using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class genertateItem : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, 3);
            Vector2 pos = new Vector2(Random.Range(-4, 4), Random.Range(-4, 4));

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
