using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCabnits : MonoBehaviour
{
    public GameObject DestructedPixelPrefab;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "child")
        {
            //this.gameObject.SetActive(false);
			collision.gameObject.GetComponent<ChildBlock>().setThisInactive();
            GameObject destructedPicelGO = Instantiate(DestructedPixelPrefab, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(destructedPicelGO, 25);
        }
    }
}
