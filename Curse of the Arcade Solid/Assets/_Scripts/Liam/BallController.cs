using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Paddle")
        {
            gameObject.AddComponent<Rigidbody>();
        }

        if(collision.gameObject.tag == "child")
        {
            collision.gameObject.GetComponent<ChildBlock>().setThisInactive();
            this.gameObject.SetActive(false);
        }
    }
}
