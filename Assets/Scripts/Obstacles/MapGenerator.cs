using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject[] ItemSpawn;
    public List<Transform> SpawnPoints;

    [Header("Кол-во предметов на слое")]
    [SerializeField] private int shouldSpawn;

    //[Header("Какое число на блоках будет")]
    //[SerializeField] public Block block;

    void Start()
    {
        SpawnPoints = new List<Transform>(SpawnPoints);
        Spawn();
    }

    public void Spawn()
    {
        var spawnCount = Mathf.Min(shouldSpawn, SpawnPoints.Count);

        for (var i = 0; i < spawnCount; i++)
        {
            var spawnIndex = Random.Range(0, SpawnPoints.Count);
            var newItem = Instantiate(ItemSpawn[Random.Range(0, ItemSpawn.Length)], SpawnPoints[spawnIndex].position, Quaternion.identity);
            //block.startingSize = Random.Range(1, 10);
            SpawnPoints.RemoveAt(spawnIndex);
        }
    }
}
