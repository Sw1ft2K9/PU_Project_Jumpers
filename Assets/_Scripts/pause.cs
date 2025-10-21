using UnityEngine;

public class Pause : MonoBehaviour
{
    public KeyCode pauseKey = KeyCode.Escape;
    public GameObject pauseMenu;
    private bool isPaused = false;
    public switchLevel SwitchLevel;
    public UI UI;
    
    
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            if (isPaused)
                ResumeSystem();
            else
                PauseSystem();
        }
    }

    public void PauseSystem()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        SwitchLevel.enabled = false;
        UI.enabled = false;
    }

    public void ResumeSystem()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        SwitchLevel.enabled = true;
        UI.enabled = true;
    }
}
