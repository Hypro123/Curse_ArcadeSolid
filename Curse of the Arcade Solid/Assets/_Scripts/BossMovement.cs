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

    public AudioSource dmgSource;
    public AudioClip dmgClip;
    [Range(0, 1.0f)]
    public float dmgVolume = 0.5f;

    [HideInInspector]
    public Vector3 dir;

    private Transform[] storechildrenAmount;

	// Use this for initialization
	void Awake ()
    {
        storechildrenAmount = this.GetComponentsInChildren<Transform>();
        dir = this.transform.forward;
        tPositions = GameObject.FindGameObjectsWithTag(SpawnBossTag);
        spawn();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if(this.GetComponent<BossHP>().getHealth() > 0)
        this.transform.position += -dir * ibossSpeed * Time.deltaTime;
    }

    void spawn()
    {
        int i = Random.Range(0, tPositions.Length);
        this.transform.position = tPositions[i].transform.position;

        foreach (Transform t in storechildrenAmount)
        {
            if (t.tag == "child")
                t.GetComponent<ChildBlock>().resetChild();
            else
                continue;
        }
    }
    public void reverseDirection()
    {
        dir = -dir;
    }

    public void stopBoss()
    {
        ibossSpeed = 0.0f;
    }
}
