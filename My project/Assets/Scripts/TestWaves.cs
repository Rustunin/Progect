using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWaves : MonoBehaviour
{
    private WaveSpawner _waveSpawner;

    private void Awake()
    {
        _waveSpawner = GameObject.Find("WaveController").GetComponent<WaveSpawner>();
    }


    private void OnDestroy()
    {
        int enemyLeft = 0;
        enemyLeft = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if(enemyLeft == 0)
        {
            _waveSpawner.Launcher();
        }
    }
}
