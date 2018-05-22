using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public Transform SpawnPosition;
    public GameObject MagicBallPrefab;
    public GameObject MagicBall;
    public float Timer = 0;

	// Update is called once per frame
	void Update ()
    {
        Timer++;
	    if(Timer == 100)
        {
            MagicBall = Instantiate(MagicBallPrefab) as GameObject;
            //MagicBall.transform.position = GameObject.FindGameObjectWithTag("Ball Spawner");
            Timer = 0;
        }
	}
}
