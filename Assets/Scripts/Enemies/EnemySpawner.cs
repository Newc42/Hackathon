using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject waveManager;
    int enemiesSpawned;

    private void Start()
    {
        InvokeRepeating("SpawnEnemies", 0, Random.Range(1f, 3f));
    }

    void SpawnEnemies(){ 
        enemiesSpawned++;
        if(enemiesSpawned >= 15){
            CancelInvoke();
        }
        Vector2 spawnPoint = new Vector2(waveManager.transform.position.x + Random.Range(-3f,3f), waveManager.transform.position.y + Random.Range(-1f,1f));
        Instantiate(waveManager.GetComponent<WavesOfEnemies>().GetEnemyPrefab(0), spawnPoint, Quaternion.identity);
    }
}
