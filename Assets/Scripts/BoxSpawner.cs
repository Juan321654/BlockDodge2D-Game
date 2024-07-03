using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;
    [SerializeField] float spawnInterval = 1f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnBox), 0, spawnInterval);
    }

    private void SpawnBox()
    {
        float xBoundary = 10f;
        float yPosition = 6f;
        float randomX = Random.Range(-xBoundary, xBoundary);
        Vector3 spawnPosition = new Vector3(randomX, yPosition, 0);
        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}
