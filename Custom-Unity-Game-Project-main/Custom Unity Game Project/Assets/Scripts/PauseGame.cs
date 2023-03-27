using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool game_paused;
    // Start is called before the first frame update
    void Start()
    {
        game_paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !game_paused)
        {
            Time.timeScale = 0;
            game_paused = true;
        }
        if (Input.GetKeyDown(KeyCode.Tab) && game_paused)
        {
            Time.timeScale = 1;
            game_paused = false;
        }
    }
}
