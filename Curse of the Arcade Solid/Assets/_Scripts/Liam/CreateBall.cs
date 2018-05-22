using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public Transform SpawnPosition;
    public GameObject MagicBallPrefab;
    public GameObject MagicBall;

    void Awake()
    {
        MagicBall = Instantiate(MagicBallPrefab, SpawnPosition) as GameObject;
    }


    public void BallCreate()
    {
        MagicBall = Instantiate(MagicBallPrefab, SpawnPosition) as GameObject;
    }
}