using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    public GameObject cactusPrefab;
    public float minSpawnRate = 1f;
    public float maxSpawnRate = 3f;
    public float spawnY = -3.5f;
    public float minScaleX = 0.5f;
    public float maxScaleX = 1.5f;
    private float nextSpawn = 0f;

    void Start()
    {
        nextSpawn = Time.time + Random.Range(minSpawnRate, maxSpawnRate);
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            float randomScaleX = Random.Range(minScaleX, maxScaleX);
            GameObject newCactus = Instantiate(cactusPrefab, new Vector3(10, spawnY, 0), Quaternion.identity);
            newCactus.transform.localScale = new Vector3(randomScaleX, newCactus.transform.localScale.y, newCactus.transform.localScale.z);
            nextSpawn = Time.time + Random.Range(minSpawnRate, maxSpawnRate);
        }
    }
}