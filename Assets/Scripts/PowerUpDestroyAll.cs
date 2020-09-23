using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpDestroyAll : MonoBehaviour
{
    EnemyKiteSpawnController enemyKiteSpawnController;
    SpawnManager spawnmanager;

    private void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            PickUp(collision);
            DestroyEnemies("Enemy");

        }
    }

    void PickUp(Collider2D player)
    {
        Destroy(gameObject);
        Debug.Log("Picked Up");
    }

    public void DestroyEnemies(string tag)
    {
        GameObject[] go = GameObject.FindGameObjectsWithTag(tag);
        foreach(GameObject target in go)
        {
            GameObject.Destroy(target);
        }
    }


}
