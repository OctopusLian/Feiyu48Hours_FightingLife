using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour {
    public GameObject npcPrefab1;
    public GameObject npcPrefab2;
    public GameObject npcPrefab3;
    private float timeSet = 0.0f;
    public GameObject _npc;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CreateNpc();

    }

    public void CreateNpc()
    {

        Vector2 pos = new Vector2(
               Random.Range(5f, 15.0f),
               Random.Range(-7.0f, 0f)
                );
        if (timeSet > 0.0f) timeSet = timeSet - Time.deltaTime;
        else
        {

            int index = Random.Range(0, 3);
            switch (index)
            {
                case 0:
                    _npc = Instantiate(npcPrefab1) as GameObject; break;
                case 1:
                    _npc = Instantiate(npcPrefab2) as GameObject; break;
                case 2:
                    _npc = Instantiate(npcPrefab3) as GameObject; break;
                default: break;

            }
            _npc.transform.position = pos;
            timeSet = 4.0f;
            
        }
    }

}
