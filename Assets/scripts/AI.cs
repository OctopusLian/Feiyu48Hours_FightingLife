using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{


    public float npc_MoveSpeed = 2.0f;

    public float _left = -15.0f;
    public float _right = 15.0f;
    public float _up = 7.0f;
    public float _down = -7.0f;

    public Vector2 pos;

    private Transform _transform;
    private GameObject player;


    // Use this for initialization

    private void Awake()
    {

    }
    void Start()
    {
        setPos();
        _transform = this.transform;


    }

    // Update is called once per frame
    void Update()
    {

        if (_transform.position.x < _left ||
             _transform.position.x > _right ||
             _transform.position.y > _up ||
             _transform.position.y < _down)
        {
            setPos();
        }

        _transform.position = Vector2.MoveTowards(_transform.position, pos, Time.deltaTime * npc_MoveSpeed);
        if (Mathf.Abs(_transform.position.x - pos.x) <= 0.01 ||
           Mathf.Abs(_transform.position.y - pos.y) <= 0.01)
        {
            setPos();
        }


    }

    public void setPos()
    {
        pos = new Vector2(
             Random.Range(_left, _right),
             Random.Range(_up, _down)
              );

    }

    public void Death()
    {
        Destroy(gameObject);
    }
}
