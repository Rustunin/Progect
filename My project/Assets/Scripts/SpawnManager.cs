using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    private float rangeOfCords = 8f;

    private int wave = 1;
    void Start()
    {
        SpawnEnemy(wave);
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectsOfType<Enemy>().Length == 0)
        {
            wave++;
            SpawnEnemy(wave);
        }
    }
    void SpawnEnemy(int value)
    {
        int Ind = Random.Range(0, enemyPrefab.Length);
        for(int i = 0; i < value; i++)
        {
            Instantiate(enemyPrefab[Ind], RandomSpawnPos(), enemyPrefab[Ind].transform.rotation);
        }
    }


    Vector3 RandomSpawnPos()
    {
        float xRange = Random.Range(-rangeOfCords, rangeOfCords);
        float zRange = Random.Range(-rangeOfCords, rangeOfCords);
        Vector3 spawnPos = new Vector3(xRange, 1, zRange);
        return spawnPos;
    }
}
