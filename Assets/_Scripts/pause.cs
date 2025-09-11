using UnityEngine;

public class pause : MonoBehaviour
{
    public KeyCode pauseKey = KeyCode.Escape;
    public GameObject Pausemenu;
    bool IsPaused = false;
    public GameObject target;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            PauseSystem();
        }
    }
    public void PauseSystem()
    {


    }
}
