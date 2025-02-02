using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;
    private float nextSpawn = 0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            Instantiate(obstaclePrefab, new Vector3(10, -3.5f, 0), Quaternion.identity);
            nextSpawn = Time.time + spawnRate;
        }
    }
}