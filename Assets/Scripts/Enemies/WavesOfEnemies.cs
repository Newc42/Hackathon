using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesOfEnemies : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyPrefabs;

    public int GetEnemyCount(){
        return enemyPrefabs.Count;
    }

    public GameObject GetEnemyPrefab(int index){
        return enemyPrefabs[index];
    }
}
