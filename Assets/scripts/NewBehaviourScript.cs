using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public SpriteRenderer s1;
    public SpriteRenderer s2;
    public bool isS1 = true;
    // Use this for initialization
    void Start()
    {

    }
    float temp = 0;
    // Update is called once per frame
    void Update()
    {
        if (Time.time - temp > 0.2f)
        {
            temp = Time.time;
            isS1 = !isS1;
            if (isS1)
            {
                s1.gameObject.SetActive(true);
                s2.gameObject.SetActive(false);
            }
            else
            {
                s1.gameObject.SetActive(false);
                s2.gameObject.SetActive(true);
            }
        }
    }
}
