using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour {

    [SerializeField]
    private int iHealth = 0;

	// Use this for initialization
	void Awake ()
    {
        iHealth = this.transform.childCount;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Transform t = this.transform.GetChild(1);
            t.gameObject.SetActive(false);
            iHealth--;
        }
	}

}
