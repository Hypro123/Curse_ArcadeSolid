using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBlock : MonoBehaviour {

    void Awake()
    {
        this.gameObject.SetActive(true);
    }

    public void setThisInactive()
    {
        this.gameObject.SetActive(false);
        this.GetComponentInParent<BossHP>().TakeDmg();
    }
}
