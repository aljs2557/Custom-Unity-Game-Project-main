using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
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
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        isGameActive = true;
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            int index = Random.Range(0, enemies.Length - 1);
            yield return new WaitForSeconds(Random.Range(5f, 15f));
            Instantiate(enemies[index], RandomSpawningPosition(), transform.rotation);
        }
    }
}
