using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleChangeAngle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//aim up
		if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) && !GameObject.FindGameObjectWithTag("GameManager").GetComponent<winCondition>().getEndGame())
		{
			if (transform.localScale.z < 3.5f) {
				transform.localScale += new Vector3 (0, 0, .05f);
			}
		}
		//aim down
		else if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && !GameObject.FindGameObjectWithTag("GameManager").GetComponent<winCondition>().getEndGame())
		{
			if (transform.localScale.z > 1f) {
				transform.localScale -= new Vector3 (0, 0, .05f);
			}
		}
	}
}
