using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(sceneName);
    }
    public void ReloadCurrentScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
