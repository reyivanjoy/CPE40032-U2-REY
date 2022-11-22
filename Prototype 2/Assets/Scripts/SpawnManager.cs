using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    private float spawnRangeX = 21.0f;
    private float spawnPosZ = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn Animals that will start a 1second and will respawn every after 2 seconds
        InvokeRepeating("SpawnAnimal", 1, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, -spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }


}
