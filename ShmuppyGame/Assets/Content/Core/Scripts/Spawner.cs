using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform spawnPoint;

    public float spawnTimer = 1;
    public float cycleTime = 10;

    public GameObject enemy;

    private float spawnTime;

 
    // Update is called once per frame
    void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime >= spawnTimer)
        {
            Spawn();
        }       
    }

    void Spawn()
    {
        GameObject ship = Instantiate(enemy,spawnPoint.position,spawnPoint.rotation);
        ship.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * 20, ForceMode.Impulse);
        spawnTime = 0;
    }
}
