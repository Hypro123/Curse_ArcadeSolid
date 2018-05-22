using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    //private GameObject BallSpawner;
	public GameObject DestructedPixelPrefab;

    private void Awake()
    {
        //BallSpawner = GameObject.FindGameObjectWithTag("Ball Spawner");
		Destroy (gameObject, 7);
    }

    void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "child")
        {
            //this.gameObject.SetActive(false);
			GameObject destructedPicelGO = Instantiate(DestructedPixelPrefab, collision.gameObject.transform.position,Quaternion.identity);
			Destroy (destructedPicelGO, 25);
            collision.gameObject.GetComponent<ChildBlock>().setThisInactive();
        }
    }
}