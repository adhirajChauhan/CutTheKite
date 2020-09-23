using UnityEngine;

public class EnemyKiteSpawnController : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyKites;
    int randomSpawnPoint, randomKites;
    public static bool spawnAllowed;
  
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnKite", 0f, 1f);
    }

    void SpawnKite()
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomKites = Random.Range(0, enemyKites.Length);
            Instantiate(enemyKites[randomKites], spawnPoints[randomSpawnPoint].position,
                Quaternion.identity);
        }
    }

    public void DestroyAll()
    {
        foreach (GameObject go in enemyKites)
        {
            Destroy(go);
        }
    }
}
