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
    private AudioSource winLoseMusic;

    [SerializeField]
    private AudioClip winClip;
    [SerializeField][Range(0, 1.0f)]
    private float volumeWin = 0.5f;
    [SerializeField]
    private AudioClip loseClip;
    [SerializeField][Range(0, 1.0f)]
    private float volumeLose = 0.5f;
    [SerializeField]
    private AudioClip backgroundMusic;
    [SerializeField][Range(0, 1.0f)]
    private float volumeBackGround = 0.5f;


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

    private bool endGameBool = false;

    private winSinario win = winSinario.NONE;

    void Awake()
    {
        endGameBool = false;
        w.SetActive(false);
        l.SetActive(false);
        source.clip = backgroundMusic;
        source.volume = volumeBackGround;
        source.Play();
        bossOBJ = GameObject.FindGameObjectWithTag("Boss");
    }

    void Update()
    {
        if(end.transform.position.z > bossOBJ.transform.position.z)
        {
            source.Stop();
            win = winSinario.LOSS;
        }
        else if(GameObject.FindGameObjectWithTag("Boss").GetComponent<BossHP>().getHealth() == 0)
        {
            source.Stop();
            win = winSinario.WIN;
        }

        //set up for possible later uses
        if (endGameBool == false)
        {
            switch (win)
            {
                case winSinario.WIN:
                    {
                        winLoseMusic.PlayOneShot(winClip, volumeWin);
                        winCanvas();
                        endGameBool = true;
                        break;
                    }
                case winSinario.LOSS:
                    {
                        GameObject.FindGameObjectWithTag("Boss").GetComponent<BossMovement>().stopBoss();
                        winLoseMusic.PlayOneShot(loseClip, volumeLose);
                        loseCanvas();
                        endGameBool = true;
                        break;
                    }
                default:
                    {
                        break;
                    }
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

    public bool getEndGame()
    {
        return endGameBool;
    }
}
