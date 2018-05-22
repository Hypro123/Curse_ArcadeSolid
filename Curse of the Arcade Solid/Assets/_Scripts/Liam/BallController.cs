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
        if(collision.gameObject.tag == "Paddle")
        {
            //gameObject.AddComponent<Rigidbody>();
            Invoke("ballController", 2);
            Debug.Log("tis not fuck");
        }

        if(collision.gameObject.tag == "child")
        {
            this.gameObject.SetActive(false);
            collision.gameObject.GetComponent<ChildBlock>().setThisInactive();
        }
    }

    void ballController()
    {
        BallSpawner.GetComponent<CreateBall>().BallCreate();
    }
}