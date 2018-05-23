using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UItest : MonoBehaviour {

    [SerializeField]
    private string mainMenuString = "MainScene1";
    [SerializeField]
    private string GameString1 = "Game1";
    [SerializeField]
    private string GameString2 = "Game2";
    [SerializeField]
    private string GameString3 = "Game3";

    public void mainScene()
    {
        SceneManager.LoadScene(mainMenuString);
    }
    public void gameScene1()
    {
        SceneManager.LoadScene(GameString1);
    }
    public void gameScene2()
    {
        SceneManager.LoadScene(GameString2);
    }
    public void gameScene3()
    {
        SceneManager.LoadScene(GameString3);
    }

}
