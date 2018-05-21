using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    private new GameObject gameObject;

	// Use this for initialization
	void Start ()
    {
        
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "DesstroyAble")
        {
            //Debug.Log("C# is fuck");
            collision.gameObject.GetComponent<ChildBlock>().setThisInactive();

        }
    }
}
