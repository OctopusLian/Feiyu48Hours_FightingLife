using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float bulletMoveSpeed = 5.0f;
    public Vector3 moveDirection;


    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(transform.position.x + "," + transform.position.y + "," + transform.position.z);
        transform.position = transform.position + moveDirection * Time.deltaTime * bulletMoveSpeed;
    }
}
