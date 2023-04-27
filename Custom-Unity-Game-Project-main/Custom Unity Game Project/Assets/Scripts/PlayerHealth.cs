using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    int health;
    public GameObject player;
    private int _score;
    public UIManager _UIManager;
    public StoreInteract StoreUI;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("FailureScreen");
        }

        //restart if player falls
        if (player.transform.position.y <= -3)
        {
            SceneManager.LoadScene("FailureScreen");
        }

        if (_score >= 250)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

    public void AddScore(int points)
    {
        _score += points;
        _UIManager.UpdateScore(_score);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            health -= 10;
            _UIManager.UpdateHealth(health);
        }
    }
}
