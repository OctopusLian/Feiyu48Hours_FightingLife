using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float m_speed = 2.0f;
    public float bulletMoveSpeed=1.5f;

    public GameObject bullet;

    public float coolDown=0.5f;

    private Vector2 mousePosWorld;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //控制玩家移动
        PlayerMove();

        //玩家射击
        coolDown = coolDown - Time.deltaTime;
        if (Input.GetMouseButtonUp(0)&&!(coolDown>0.0f))//如果点击了鼠标左键
        {
            
            //创建一条从摄像机到点击位置的射线，并赋值给ray
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //如果射线发生物理碰撞（且将碰撞内容赋给hit）
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit))
            {

                Vector3 dir = hit.point - transform.position;

                PlayerShoot(dir);
                coolDown = 0.5f;
            }
        }


    }

    public void PlayerMove()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * Time.deltaTime * m_speed, 0));
        transform.Translate(new Vector2(0, Input.GetAxis("Vertical") * Time.deltaTime * m_speed));
    }

    public void PlayerShoot(Vector3 Direction)
    {
        GameObject bulletObj = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
        bulletObj.SetActive(true);
        bulletObj.transform.parent = gameObject.transform;
        Bullet bulletCmp = bulletObj.GetComponent<Bullet>();
        bulletCmp.moveDirection = new Vector3(Direction.x , Direction.y , 0);
        bulletCmp.moveDirection.Normalize();
        //GameManager.Instance.BulletCollector.Add(bulletCmp);
        //float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");
        //bulletCmp.transform.Translate(Vector2.right * Time.deltaTime * bulletMoveSpeed);
        //_transform.position = Vector2.MoveTowards(_transform.position, mousePosWorld, Time.deltaTime * bulletMoveSpeed);
    }
}
