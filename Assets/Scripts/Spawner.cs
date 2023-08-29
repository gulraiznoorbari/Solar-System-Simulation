using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab = null;
    [SerializeField] private float spawnTime = 5.0f;

    // keep track of time passed for next spawn
    private float nextSpawn = 0f;

    private void Start()
    {
        nextSpawn = 0f;
    }

    private void Update()
    {
        // update the time until nextSpawn
        nextSpawn += Time.deltaTime;
        if (nextSpawn > spawnTime)
        {
            // Spawn the gameObject at the spawners current position and rotation
            GameObject projectileGameObject = Instantiate(spawnPrefab, transform.position, transform.rotation, null);
            // reset the time until nextSpawn
            nextSpawn = 0f;
        }

    }
}
