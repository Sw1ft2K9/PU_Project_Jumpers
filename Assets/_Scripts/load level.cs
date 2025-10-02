using UnityEngine;
using UnityEngine.SceneManagement;
public class loadlevel : MonoBehaviour
{
    public void LoadScene(int levelID)
    {
        SceneManager.LoadScene(levelID);

    }
    public void QuitGame()
    {
        Application.Quit();

    }
}
