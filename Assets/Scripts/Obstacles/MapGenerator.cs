using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject[] ItemSpawn;
    public List<Transform> SpawnPoints;

    void Start()
    {
        SpawnPoints = new List<Transform>(SpawnPoints);
        Spawn();
    }

    void Spawn()
    {
        for (var i = 0; i < 6; i++)
        {
            var spawnIndex = Random.Range(0, SpawnPoints.Count);
            GameObject newItem = Instantiate(ItemSpawn[Random.Range(0, ItemSpawn.Length)], SpawnPoints[spawnIndex].transform.position, Quaternion.identity);
            SpawnPoints.RemoveAt(spawnIndex);
        }
    }
}
