using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("loadingLevel", 1));
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}