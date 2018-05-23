using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverseBoss : MonoBehaviour {

    [SerializeField]
    private bool inverse = false;

    private float count = 0;
    private bool canGoBack = false;

    void Awake()
    {
        count = 0;
        canGoBack = false;
    }

    void Update()
    {
        if (!inverse)
        {
            if (this.transform.position.z >= GameObject.FindGameObjectWithTag("Boss").transform.position.z)
            {
                GameObject.FindGameObjectWithTag("Boss").GetComponent<BossMovement>().reverseDirection();
                this.gameObject.SetActive(false);
            }
        }
        else
        {
            if (this.transform.position.z >= GameObject.FindGameObjectWithTag("Boss").transform.position.z)
            {
                count += Time.deltaTime;
                if(count >= 2)
                {
                    canGoBack = true;
                }
            }
            if (canGoBack && this.transform.position.z <= GameObject.FindGameObjectWithTag("Boss").transform.position.z)
            {
                GameObject.FindGameObjectWithTag("Boss").GetComponent<BossMovement>().reverseDirection();
                this.gameObject.SetActive(false);
            }
        }
    }
}
