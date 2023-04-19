using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    public Transform Player;
    public float MoveSpeed;
    int MinDist = 0;
    int MaxDist = 1;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            MoveSpeed = 8;
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }

        if (Vector3.Distance(transform.position, Player.position) >= MaxDist)
        {
            MoveSpeed = 0;
        }
    }
}
