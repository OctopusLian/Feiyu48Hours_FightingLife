using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PickUp : MonoBehaviour
{
    public Rigidbody2D barrier;
    public GameObject pickedItem;
    public GameObject imageShown;
   
    private void Awake()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("exsit");
        pickedItem = other.gameObject;
        imageShown.GetComponentInChildren<SpriteRenderer>().sprite = pickedItem.GetComponentInChildren<SpriteRenderer>().sprite;

        Destroy(other.gameObject);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //  Display();
    }

    public void Display() {

        //imageShown.sprite = pickedItem.GetComponent<Image>().sprite;

    }
}