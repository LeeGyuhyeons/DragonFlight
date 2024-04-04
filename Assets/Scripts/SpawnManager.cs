using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject enemy;

    List<float> spawnList = new List<float>();


    void Start()
    {
        InvokeRepeating("Spawn", 1.0f, 1.0f);
        InvokeRepeating("LineSpawn", 5.0f, 5.0f);


        spawnList.Add(-2.0f);
        spawnList.Add(-1.0f);
        spawnList.Add(0f);
        spawnList.Add(1.0f);
        spawnList.Add(2.0f);
    }

    void LineSpawn()
    {

        for (int i = 0; i < spawnList.Count; i++)
        {
            transform.position = new Vector3(spawnList[i], transform.position.y, 0);
            if (enableSpawn)
            {

                Instantiate(enemy, transform.position, Quaternion.identity);
            }

        }

    }

    void Spawn()
    {
        float randomX = Random.Range(-2f, 2f);
        transform.position = new Vector3(randomX, transform.position.y, 0);


        if (enableSpawn)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);

        }


    }

    void Update()
    {

    }
}
