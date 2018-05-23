using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBlock : MonoBehaviour {

    //private AudioSource Asource;
    //private AudioClip Aclip;
    //private float volume = 0.5f;

    void Awake()
    {

       // Aclip = this.GetComponentInParent<BossMovement>().dmgClip;
       // volume = this.GetComponentInParent<BossMovement>().dmgVolume;

       // Asource.clip = Aclip;
       // Asource.volume = volume;

        resetChild();
    }

    public void setThisInactive()
    {
        this.gameObject.SetActive(false);
        this.GetComponentInParent<BossHP>().TakeDmg();        
      //  Asource.PlayOneShot(Aclip, volume);
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
