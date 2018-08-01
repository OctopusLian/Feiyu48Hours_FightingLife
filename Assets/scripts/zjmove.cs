using UnityEngine;
using System.Collections;

public class zjmove : MonoBehaviour
{
    private bool bCube1 = false;  //鼠标左键
    private bool bCube2 = false;  //鼠标右键
    
    public float speed = 100f;  //速度
    public GameObject explode;
    public float maxLiftTime = 10f;
    public float instantiateTime = 0f;

    public GameObject Cylinder;

    //攻击方
    public GameObject attackTank;

    //爆炸音效
    public AudioClip explodeClip;

   // public LineRenderer lineRenderer;

    public float start_time = 0.0f;
    public Vector3 start_piont;
    public Vector3 end_piont;
    void Start()
    {
        instantiateTime = Time.time;
        //lineRenderer.enabled = false;
    }

    void Update()
    {
        /*
        Vector3[] v = new Vector3[2];
        v[0] = transform.position;
        Vector3 v1 = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z);  //鼠标x轴，鼠标y轴，起始点z轴
        v[1] = v1;

        lineRenderer.SetPositions(v);
        */
        if (bCube1)  //按鼠标左键，射击
        {

            //前进
            //transform.position += transform.right * speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, end_piont, Time.deltaTime * speed);
           
            //摧毁
            if (Time.time - instantiateTime > maxLiftTime)
                Destroy(gameObject);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            start_piont = transform.position;
            end_piont = new Vector3(Input.mousePosition.x,Input.mousePosition.y,Input.mousePosition.z);
            bCube1 = true;
        }

        if(Input.GetMouseButton(1))
        {
           Cylinder.SetActive(true);
        }
       
        /*
        Ray ray = new Ray(transform.position , transform.right);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            // 如果射线与平面碰撞，打印碰撞物体信息  
            Debug.Log("碰撞对象: " + hit.collider.name);
            // 在场景视图中绘制射线  
            Debug.DrawRay(transform.position, hit.point, Color.red);
        }*/

       
       

}

//碰撞
void OnCollisionEnter(Collision collisionInfo)
    {
        //打到自身
        if (collisionInfo.gameObject == attackTank)
            return;

        //爆炸效果
        GameObject explodeObj = (GameObject)Instantiate(explode, transform.position, transform.rotation);
        //爆炸音效
        AudioSource audioSource = explodeObj.AddComponent<AudioSource>();
        audioSource.spatialBlend = 1;
        audioSource.PlayOneShot(explodeClip);
        //摧毁自身
        Destroy(gameObject);
        //击中坦克
        /*Tank tank = collisionInfo.gameObject.GetComponent<Tank>();
        if (tank != null)
        {
            float att = GetAtt();
            tank.BeAttacked(att, attackTank);
        }
        */
        //发送伤害信息

    }

    //计算攻击力
    private float GetAtt()
    {
        float att = 100 - (Time.time - instantiateTime) * 40;
        if (att < 1)
            att = 1;
        return att;
    }

    /*
    private int force = 10;
    private float m_speed = 5f;
    private Rigidbody rd;
    public PickUp item;
    // Use this for initialization
    void Start()
    {
        rd = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(horizontal, 0, vertical) * force);
        rd.transform.Translate(Vector3.forward * vertical * m_speed * Time.deltaTime);
        rd.transform.Translate(Vector3.right * horizontal * m_speed * Time.deltaTime);

    }
    */
}
