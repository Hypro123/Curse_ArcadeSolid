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
    [SerializeField][Tooltip("The end point")]
    private GameObject end;
    private GameObject bossOBJ;
    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioClip winClip;
    [SerializeField]
    private AudioClip loseClip;

    private winSinario win = winSinario.NONE;

    void Awake()
    {
        bossOBJ = GameObject.FindGameObjectWithTag("Boss");
    }

    void Update()
    {
        if(end.transform.position.z >= bossOBJ.transform.position.z)
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
                    Debug.Log("you win!!");
                    source.PlayOneShot(winClip, 5.0f);
                    break;
            }
            case winSinario.LOSS:
            {
                    //Debug.Log("You are bad at league!");
                    GameObject.FindGameObjectWithTag("Boss").GetComponent<BossMovement>().stopBoss();
                    source.PlayOneShot(loseClip, 5.0f);
                    break;
            }
            default:
            {
                break;
            }
        }
    }
}
