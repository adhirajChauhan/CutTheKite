using System.Collections;
using System.Collections.Generic;
//using Unity.Mathematics;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] powerUps;
    [SerializeField]
    private GameObject _powerUpContainer;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SpawnRoutine());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Vector2 posToSpawn = new Vector2(Random.Range(-2.4f, 2.4f), Random.Range(3.6f, -4.2f));
            GameObject clonedPowerUps = Instantiate(powerUps[Random.Range(0, powerUps.Length)], posToSpawn, Quaternion.identity);
            clonedPowerUps.transform.parent = _powerUpContainer.transform;
            yield return new WaitForSeconds(5.0f);


        }


    }

}
