using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    public Text _scoreText;
    public Text _healthText;

    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Points: " + 0;
        _healthText.text = "Health: " + 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int playerScore)
    {
        _scoreText.text = "Points: " + playerScore.ToString();
    }

    public void UpdateHealth(int playerHealth)
    {
        _healthText.text = "Health: " + playerHealth.ToString();
    }
}
