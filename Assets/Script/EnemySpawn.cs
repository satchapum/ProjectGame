using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject knightFire;
    [SerializeField] GameObject knightWater;
    [SerializeField] GameObject knightWood;
    [SerializeField] Transform enemyPos;
    [SerializeField] GameSettingScript setting;

    int numberType;
    public float spawnTime;
    public float minSpawnDelay;
    public float maxSpawnDelay;  
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, GetRandomSpawnDelay());
    }

    void SpawnEnemy() {
        if(setting.enemyAmount >= 0 && setting.enemyAmount < 3 && setting.isSpawn == false) {
            numberType = Random.Range(1,4);
            if(numberType == 1) {
                GameObject obj = Instantiate(knightFire, enemyPos.position, enemyPos.rotation);
                obj.SetActive(true);
            }
            else if(numberType == 2) {
                GameObject obj = Instantiate(knightWater, enemyPos.position, enemyPos.rotation);
                obj.SetActive(true);
            }
            else if(numberType == 3){
                GameObject obj = Instantiate(knightWood, enemyPos.position, enemyPos.rotation);
                obj.SetActive(true);
            }
            Invoke("SpawnEnemy", GetRandomSpawnDelay());
        }
    }

    float GetRandomSpawnDelay()
    {
        return Random.Range(minSpawnDelay, maxSpawnDelay);
    }
}