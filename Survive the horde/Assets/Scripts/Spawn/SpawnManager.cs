using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public GameObject bossPrefab;
    public GameObject enemyPrefab;
    public int enemyCount;
    public int waveNumber = 1;
    public float timer;
    public int waitingTime = 5;
    private float spawnRange = 30;


    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);

        }

        if(enemyCount == 10)
        {
            Boss();
            Destroy(gameObject);
        }

    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    private Vector3 SpawnPosition()
    {
        Vector3 bossPos = new Vector3(0, 0, 12);
        return bossPos;
    }

    private void Boss()
    {
        Instantiate(bossPrefab, SpawnPosition(), bossPrefab.transform.rotation);
    }

}