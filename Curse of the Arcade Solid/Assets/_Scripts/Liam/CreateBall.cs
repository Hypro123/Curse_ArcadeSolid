using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public Transform SpawnPosition;
    public GameObject BallPrefab;
    public GameObject MagicBall;

    void Awake()
    {
        MagicBall = Instantiate(BallPrefab, SpawnPosition) as GameObject;
    }


    public void BallCreate()
    {
        MagicBall = Instantiate(BallPrefab, SpawnPosition) as GameObject;
    }
}