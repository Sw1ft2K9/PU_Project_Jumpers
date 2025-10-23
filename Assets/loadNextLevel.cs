using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNextLevel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 1"))
            {
                SceneManager.LoadScene("level 2");
            }
            else
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 2"))
            {
                SceneManager.LoadScene("level 3");
            }
            else
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 3"))
            {
                SceneManager.LoadScene("level 4");
            }
            else
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 4"))
            {
                SceneManager.LoadScene("level 5");
            }
        }
    }
}
