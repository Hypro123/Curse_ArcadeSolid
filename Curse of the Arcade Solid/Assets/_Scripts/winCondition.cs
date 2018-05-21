using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum winSinario
{
    LOSS,
    WIN,
    NONE
}

public class winCondition : MonoBehaviour
{
    [SerializeField]
    private GameObject end;
    [SerializeField]
    private GameObject start;

    private winSinario win = winSinario.NONE;

    void Update()
    {
        if(end.transform.position.z >= start.transform.position.z)
        {
            win = winSinario.LOSS;
        }
        else if(GameObject.FindGameObjectWithTag("Boss").GetComponent<BossHP>().hp == 0)
        {
            win = winSinario.WIN;
        }
        
        //set up for possible later uses
        switch (win)
        {
            case winSinario.WIN:
            {
                break;
            }
            case winSinario.LOSS:
            {
                break;
            }
            default:
            {
                break;
            }
        }
    }
}
