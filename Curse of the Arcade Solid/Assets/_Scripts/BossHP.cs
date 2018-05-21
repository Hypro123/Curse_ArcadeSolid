using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour {

    [SerializeField]
    private int iHealth = 0;
    [HideInInspector]
    public int hp
    {
        get
        {
            return iHealth;
        }
        set
        {
            iHealth = hp;
        }
    }
	// Use this for initialization
	void Awake ()
    {
        resetHealth();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (iHealth < 0)
            iHealth = 0;

        //temp test code --- REMOVE BEFORE TESTING FINAL RESULT
        //if (Input.GetKeyDown(KeyCode.W) && iHealth > 0)
        //{
        //    this.transform.GetChild(iHealth - 1).GetComponent<ChildBlock>().setThisInactive();
        //}
    }

    public void TakeDmg()
    {
        iHealth--;
    }
    //resets the health
    public void resetHealth()
    {
        //health is equal to the amount of children still active
        iHealth = this.transform.childCount;
    }
}
