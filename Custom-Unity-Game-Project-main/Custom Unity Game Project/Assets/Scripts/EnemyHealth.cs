using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int worth;
    public EnHe damage;
    public int health;
    public GameObject enemy;
    private PlayerHealth _player;
    void Start()
    {
        damage = GameObject.Find("controller").GetComponent<EnHe>();
        _player = GameObject.Find("Player").GetComponent< PlayerHealth > ();
    }

    private void Update()
    {
        if (health <= 0)
        {
            _player.AddScore(worth);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Bullet"))
        {
            health -= damage.getDamage();
        }
    }
}
