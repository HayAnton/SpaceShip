using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float timeras = 3;
    private float timership = 5;

    public GameObject asteroidPrefab1;
    public GameObject asteroidPrefab2;
    public GameObject asteroidPrefab3;
    public GameObject shipPrefab;

    bool TimerFinishedas()
    {
        timeras -= Time.deltaTime;

        if(timeras <= 0)
        {
            timeras = 3f;
            return true;
        }
        else
        {
            return false;
        }
    }
    bool TimerFinisheadship()
    {
        timership -= Time.deltaTime;

        if (timership <= 0)
        {
            timership = 5f;
            return true;
        }
        else
        {
            return false;
        }
    }

    void Update()
    {
        if (TimerFinishedas())
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-70, 70), 3, 150);

            Instantiate(asteroidPrefab1, spawnPosition, asteroidPrefab1.transform.rotation);
            Instantiate(asteroidPrefab2, spawnPosition, asteroidPrefab2.transform.rotation);
            Instantiate(asteroidPrefab3, spawnPosition, asteroidPrefab3.transform.rotation);
        }
        if (TimerFinisheadship())
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-30, 30), 3, 150);

            Instantiate(shipPrefab, spawnPosition, shipPrefab.transform.rotation);
        }
    }
}
