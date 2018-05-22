using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBlock : MonoBehaviour {

    void Awake()
    {
        resetChild();
    }

    public void setThisInactive()
    {
        this.gameObject.SetActive(false);
        this.GetComponentInParent<BossHP>().TakeDmg();
    }
    public void resetChild()
    {
        this.gameObject.SetActive(true);
    }

    public bool endGame()
    {
        if (this.GetComponentInParent<BossHP>().getHealth() > 0)
            return true;
        else
            return false;
    }
}
