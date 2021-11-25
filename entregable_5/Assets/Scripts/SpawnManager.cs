using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    private int randomRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0.5f, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 SpawnObstacle()
    {
        float randomY = Random.Range(-randomRange, randomRange);
        return new Vector3(randomY, spawnPos.z + 50);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }

    
}
