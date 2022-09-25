using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreatSpawnerController : MonoBehaviour
{
    //Object to spawn
    public GameObject[] threats;

    //Spawn rate
    public int minSpawnRate = 1;
    public int maxSpawnRate = 5;


    // Start is called before the first frame update
    void Start()
    {
        //Start spawning objects
        InvokeRepeating("SpawnThreat", 0, Random.Range(minSpawnRate, maxSpawnRate));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnThreat()
    {
        //Spawn object at spawner position
        Instantiate(threats[Random.Range(0,threats.Length)], transform.position, Quaternion.identity);
    }

}
