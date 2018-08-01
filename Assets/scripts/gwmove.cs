using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    private float moveSpeed = 1.5F;
    // Use this for initialization
    void Start () {
        transform.position = new Vector3(4.66F, 0.04F, 0);                 //设置物体初始位置
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < 40)                                         //判断物体的位置
        {
            //物体移动
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);          //控制物体左右移动，-moveSpeed与moveSpeed方向相反
        }
        else
            transform.position = new Vector3(4.66F, 0.04F, 0);         //超过指定位置，物体回到初始位置
    }
}
