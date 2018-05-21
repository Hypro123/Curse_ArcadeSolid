using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    [SerializeField]
	float ibossSpeed = 10.0f;
    [SerializeField]
    string SpawnBossTag = "bossSpawn";
    [SerializeField]
    GameObject[] tPositions;

	// Use this for initialization
	void Awake ()
    {
        tPositions = GameObject.FindGameObjectsWithTag(SpawnBossTag);
        spawn();
    }
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.position -= this.transform.forward * ibossSpeed * Time.deltaTime;
	}

    void spawn()
    {
        int i = Random.Range(0, tPositions.Length);
        this.transform.position = tPositions[i].transform.position;
    }
}
