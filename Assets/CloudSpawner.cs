using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject[] cloudPrefabs;
    public float minSpawnRate = 1f;
    public float maxSpawnRate = 3f;
    public float spawnDistance = 10f;
    public float minY = 2f;
    public float maxY = 4f;
    private float nextSpawn = 0f;

    void Start()
    {
        nextSpawn = Time.time + Random.Range(minSpawnRate, maxSpawnRate);
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            int randomIndex = Random.Range(0, cloudPrefabs.Length);
            float spawnY = Random.Range(minY, maxY);
            Vector3 spawnPosition = new Vector3(Camera.main.transform.position.x + spawnDistance, spawnY, 0);
            Instantiate(cloudPrefabs[randomIndex], spawnPosition, Quaternion.identity);
            nextSpawn = Time.time + Random.Range(minSpawnRate, maxSpawnRate);
        }
    }
}