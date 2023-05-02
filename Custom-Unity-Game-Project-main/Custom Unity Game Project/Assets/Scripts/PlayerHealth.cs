using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    int health;
    public int defense = 10;
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
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("FailureScreen");
        }

        //restart if player falls
        if (player.transform.position.y <= -3)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("FailureScreen");
        }

        if (_score >= 250)
        {
            Cursor.lockState = CursorLockMode.None;
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
            health -= defense;
            _UIManager.UpdateHealth(health);
        }
    }

    public int getDefense()
    {
        return defense;
    }

    public void setDefense(int newDefense)
    {
        defense = newDefense;
    }
}
