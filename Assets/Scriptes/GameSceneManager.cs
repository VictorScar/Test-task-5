using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
}
