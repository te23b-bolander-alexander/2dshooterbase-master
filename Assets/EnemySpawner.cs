using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;

    [SerializeField]
    float timeBetweenSpawns = 1f;
    float timeSinceLastSpawn = 0;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn > timeBetweenSpawns);
        {
             Instantiate(enemyPrefab);
             timeSinceLastSpawn = 0;
        }
       
    



    }
}