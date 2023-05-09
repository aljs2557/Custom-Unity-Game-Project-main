using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadControl()
    {
        SceneManager.LoadScene("ControlScreen");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Level01");
    }

    public void LoadTitle()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
