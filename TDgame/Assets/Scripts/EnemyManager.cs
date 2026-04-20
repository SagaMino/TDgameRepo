using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager main;

    

    //Array
    public Transform[] checkpoint;
    public Transform spawnPoint;

    [SerializeField] private int totalCount = 6;


    //Prefabs/enemyTypes
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;
    [SerializeField] private GameObject enemy3;

    [SerializeField] private float enemyRate = 0.5f;
    [SerializeField] private float enemy1Rate = 0.4f;
    [SerializeField] private float enemy2Rate = 0.3f;
    [SerializeField] private float enemy3Rate = 0.1f;

    private List<GameObject> waveset = new List<GameObject>();
    private int enemyLeft;

    private int enemyCount;
    private int enemy1Count;
    private int enemy2Count;
    private int enemy3Count;




    void Awake()
    {
        main = this;
        SetWave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetWave()
    {
        enemyCount = Mathf.RoundToInt(enemyRate * totalCount);
        enemy1Count = Mathf.RoundToInt(enemy1Rate * totalCount);
        enemy2Count = Mathf.RoundToInt(enemy2Rate * totalCount);
        enemy3Count = Mathf.RoundToInt(enemy3Rate * totalCount);
        

        waveset = new List<GameObject>();

        for (int i = 0; i < enemyCount; i++)
        {
            waveset.Add(enemy);
        }

        for (int i = 0; i < enemy1Count; i++)
        {
            waveset.Add(enemy1);
        }

        for (int i = 0; i < enemy2Count; i++)
        {
            waveset.Add(enemy2);
        }

        for (int i = 0; i < enemy3Count; i++)
        {
            waveset.Add(enemy3);
        }

        StartCoroutine(SpawnCor());
    }

    IEnumerator SpawnCor()
    {
        for (int i = 0; i < waveset.Count; i++)
        {
            Instantiate(waveset[i], spawnPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
     



}
