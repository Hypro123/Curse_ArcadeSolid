using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public Transform SpawnPosition;
    public GameObject BallPrefab;
    //public GameObject MagicBall;

    void Awake()
    {
        Instantiate(BallPrefab, SpawnPosition);
    }


    public void BallCreate()
    {
        Instantiate(BallPrefab, SpawnPosition);
    }
}