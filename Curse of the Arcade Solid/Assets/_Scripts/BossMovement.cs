using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    [SerializeField]
    float ibossSpeed = 10;
    [SerializeField][Tooltip("This is the tag the defines on of the locations the boss can spawn in!")]
    string SpawnBossTag = "bossSpawn";
    GameObject[] tPositions;

    [HideInInspector]
    public Vector3 dir;

	// Use this for initialization
	void Awake ()
    {
        dir = this.transform.forward;
        tPositions = GameObject.FindGameObjectsWithTag(SpawnBossTag);
        spawn();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if(this.GetComponent<BossHP>().hp > 0)
        this.transform.position -= dir * ibossSpeed * Time.deltaTime;
    }

    void spawn()
    {
        int i = Random.Range(0, tPositions.Length);
        this.transform.position = tPositions[i].transform.position;

        for (int j = 0; j < this.transform.childCount; ++j)
        {
            this.transform.GetChild(j).GetComponent<ChildBlock>().resetChild();
            this.GetComponent<BossHP>().resetHealth();
        }
    }
    public void changeDir(Vector3 direct)
    {
        dir = direct;
    }

    public void stopBoss()
    {
        ibossSpeed = 0.0f;
    }
}
