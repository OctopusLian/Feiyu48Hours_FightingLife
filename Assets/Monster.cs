using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    public GameObject scorePanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        scorePanel = GameObject.Find("score");
        scorePanel.GetComponentInChildren<SpriteRenderer>().sprite = this.GetComponentInChildren<SpriteRenderer>().sprite;
        Destroy(this.gameObject);
    }
}
