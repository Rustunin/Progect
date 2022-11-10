using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public List<Transform> spawnPoints;

    private int wave = 1;
    void Start()
    {
        spawnPoints = new List<Transform>(spawnPoints);
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
        int Ind = Random.Range(0, spawnPoints.Count);
        for(int i = 0; i < value; i++)
        {
            Instantiate(enemyPrefab[Ind], spawnPoints[Ind].transform.position, enemyPrefab[Ind].transform.rotation);
            spawnPoints.RemoveAt(Ind);
        }
    }


}
