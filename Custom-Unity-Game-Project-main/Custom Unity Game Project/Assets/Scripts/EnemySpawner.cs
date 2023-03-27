using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float SpawningRange;
    public bool isGameActive;

    public Vector3 RandomSpawningPosition()
    {
        float xPos = Random.Range(transform.position.x - SpawningRange, transform.position.x + SpawningRange);
        float zPos = Random.Range(transform.position.z - SpawningRange, transform.position.z + SpawningRange);

        Vector3 SpawningPos = new Vector3(xPos, transform.position.y, zPos);

        return SpawningPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isGameActive == false)
        {
            isGameActive = true;

            Instantiate(EnemyPrefab, RandomSpawningPosition(), transform.rotation);
            Instantiate(EnemyPrefab, RandomSpawningPosition(), transform.rotation);
            Instantiate(EnemyPrefab, RandomSpawningPosition(), transform.rotation);
            Instantiate(EnemyPrefab, RandomSpawningPosition(), transform.rotation);
            Instantiate(EnemyPrefab, RandomSpawningPosition(), transform.rotation);
            Instantiate(EnemyPrefab, RandomSpawningPosition(), transform.rotation);
            Instantiate(EnemyPrefab, RandomSpawningPosition(), transform.rotation);
        }
    }
}
