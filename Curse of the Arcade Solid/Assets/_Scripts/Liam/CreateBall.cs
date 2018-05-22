using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public Transform SpawnPosition;
    public GameObject BallPrefab;
    [SerializeField] [Tooltip("in Seconds!")]
    private float ballSpawnDelay = 2.0f;

    private float Timer = 0.0f;

    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= ballSpawnDelay) {
            if (!GameObject.FindGameObjectWithTag("GameManager").GetComponent<winCondition>().getEndGame())
                BallCreate();
            Timer = 0;
        }
    }

    void BallCreate()
    {
        Instantiate(BallPrefab, SpawnPosition);
    }
}