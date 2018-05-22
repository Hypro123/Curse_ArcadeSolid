using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private GameObject BallSpawner;

    private void Awake()
    {
        BallSpawner = GameObject.FindGameObjectWithTag("Ball Spawner");
    }

    void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "child")
        {
            this.gameObject.SetActive(false);
            collision.gameObject.GetComponent<ChildBlock>().setThisInactive();
        }
    }
}