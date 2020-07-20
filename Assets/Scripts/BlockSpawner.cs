using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    public float timeToWaves = 1f;
    private float timeToSpawn = 1f;
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
                SpawnBlocks();
            timeToSpawn = Time.time + timeToWaves;
            timeToWaves -= 0.015f;
            Debug.Log(timeToWaves);
        }
    }
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        int randomIndex2 = Random.Range(0, spawnPoints.Length);

        if (randomIndex != randomIndex2)
        {
            Instantiate(blockPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
            Instantiate(blockPrefab, spawnPoints[randomIndex2].position, Quaternion.identity);
        }
        else Instantiate(blockPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}
