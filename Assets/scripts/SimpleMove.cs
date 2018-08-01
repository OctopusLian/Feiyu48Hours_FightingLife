using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleMove : MonoBehaviour {
    public Rigidbody2D player;
    private int force = 10;
    private float m_speed = 2f;
	// Use this for initialization
	void Start () {
        player = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
       // UnityEngine.SceneManagement.SceneManager.load
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        player.AddForce(new Vector2(horizontal, vertical) * force);
        player.transform.Translate(Vector2.up * vertical * m_speed * Time.deltaTime);
        player.transform.Translate(Vector2.right * horizontal * m_speed * Time.deltaTime);
    }
}
