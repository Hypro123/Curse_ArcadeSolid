using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour {

    [SerializeField]
    private int iHealth = 0;

	// Use this for initialization
	void Awake ()
    {
        //amount of children in the object specifies the amount of health
        iHealth = this.transform.childCount;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //make sure the hp doesnt overflow
        if (iHealth > 0)
            iHealth = 0;
	}
    //reduces health by 1, called by child block
    public void TakeDmg()
    {
        iHealth--;
    }
}
