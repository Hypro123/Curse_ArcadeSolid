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
    [Header("Locations")]
    [SerializeField][Tooltip("The end point")]
    private GameObject end;
    private GameObject bossOBJ;
    [Header("Sound")]
    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioClip winClip;
    [SerializeField]
    private AudioClip loseClip;
    [SerializeField]
    private AudioClip backgroundMusic;
    [Header("Canvas references")]
    [SerializeField][Tooltip("Reference to the win canvas!")]
    private GameObject w;
    [SerializeField][Tooltip("Reference to the lose canvas!")]
    private GameObject l;
    [Header("Scene name references")]
    [SerializeField]
    private string scne = "MasterScene";
    [SerializeField]
    private string mmenu = "MainMenu";

    private winSinario win = winSinario.NONE;

    void Awake()
    {
        w.SetActive(false);
        l.SetActive(false);
        source.clip = backgroundMusic;
        bossOBJ = GameObject.FindGameObjectWithTag("Boss");
    }

    void Update()
    {
        if(end.transform.position.z > bossOBJ.transform.position.z)
        {
            win = winSinario.LOSS;
        }
        else if(GameObject.FindGameObjectWithTag("Boss").GetComponent<BossHP>().getHealth() == 0)
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
                    winCanvas();
                    break;
            }
            case winSinario.LOSS:
            {
                    //Debug.Log("You are bad at league!");
                    GameObject.FindGameObjectWithTag("Boss").GetComponent<BossMovement>().stopBoss();
                    source.PlayOneShot(loseClip, 5.0f);
                    loseCanvas();
                    break;
            }
            default:
            {
                source.Play();
                break;
            }
        }
    }
    //reloads current scene, 
    public void reLoadScene()
    {
        SceneManager.LoadScene(scne);
    }
    //returns to main menu scene
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(mmenu);
    }
    //win canvas enable
    void winCanvas()
    {
        l.SetActive(false);
        w.SetActive(true);
    }
    //lose canvas enable
    void loseCanvas()
    {
        w.SetActive(false);
        l.SetActive(true);
    }

}
