using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour {

    private Transform[] children;

    [SerializeField]
    private string childTag = "child";
    [SerializeField]
    private int iHealth = 0;

    [SerializeField]
    private bool enableDebug = true;

    ChildBlock[] g;

    public int getHealth()
    {
        return iHealth;
    }

	// Use this for initialization
	void Awake ()
    {
        g = GetComponentsInChildren<ChildBlock>();
        children = GetComponentsInChildren<Transform>();
        resetHealth();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (iHealth < 0)
            iHealth = 0;
        if (enableDebug)
            DebugFunction();
    }

    public void TakeDmg()
    {
        iHealth--;
    }
    //resets the health
    public void resetHealth()
    {
        iHealth = 0;
        //health is equal to the amount of children still active
        foreach(Transform t in children)
        {
            if(t.tag == childTag)
            {
                iHealth++;
            }
        }
    }

    void DebugFunction()
    {
        if (Input.GetKeyDown(KeyCode.P))
            g[5].setThisInactive();
    }
}
