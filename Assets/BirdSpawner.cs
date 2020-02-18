using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] birds;
    int randomSpawnPoint, randomBird;
    private static bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnABird", 0f, 1f);
    }

    // Update is called once per frame
    void SpawnABird()
    {
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        randomBird = Random.Range(0, birds.Length);
        if (spawnAllowed)
        {
            Instantiate(birds[randomBird], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
