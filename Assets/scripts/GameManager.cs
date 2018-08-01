using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager Instance;
    public string start;
    public string level1;
    public string level2;
    public string level3;

    //public GameObject player;

   

    
  
    public int sence_npc_num;
   // private GameObject _player;
  

    private int create_npc_num = 0;
    private int m_score = 0;  //得分

    public Slider m_AimSlider;
    public float maxTime = 100;
    private float time_life = 100;

    public List<Bullet> BulletCollector = new List<Bullet>();


    // Use this for initialization
    private void Awake()
    {
        //_player = Instantiate(player) as GameObject;
        // _player.transform.position = new Vector2(0, 0);
        Instance = this;
    }
    void Start()
    {
        m_AimSlider.value = maxTime;
        //for (int i = 0; i < sence_npc_num; i++)
            //CreateNpc();
    }

   
    // Update is called once per frame
    void Update()
    {

        time_life -= Time.deltaTime;
        m_AimSlider.value = time_life;
        if(time_life <= 0)  //切换场景
        {
            SceneManager.LoadScene(level2);
        }
    }
    public void SetPlayerPos()
    {
       
            Vector2 pos = new Vector2(
                   Random.Range(-15.0f, 15.0f),
                   Random.Range(-7.0f, 7.0f)
                    );
            // _player.transform.position = pos;
        
    }
    


    public void AddScore(int score)
    {
        m_score += score;

    }
    public void AddTime(int time)
    {
        time_life += time;

    }


   
}