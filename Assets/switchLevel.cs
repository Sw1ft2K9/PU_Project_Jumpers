using UnityEngine;

public class switchLevel : MonoBehaviour
{
    public GameObject Red;
    public GameObject Green;
    public GameObject Blue;
    public GameObject RedLevel;
    public GameObject GreenLevel;
    public GameObject BlueLevel;
    public bool level1;
    public bool level2;
    public bool level3;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        RedLevel = GameObject.FindGameObjectWithTag("level 1");
        GreenLevel = GameObject.FindGameObjectWithTag("level 2");
        BlueLevel = GameObject.FindGameObjectWithTag("level 3");
        level1 = true;
        level2 = false;
        level3 = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        BlueLevel = GameObject.FindGameObjectWithTag("level 3");
        RedLevel = GameObject.FindGameObjectWithTag("level 1");
        GreenLevel = GameObject.FindGameObjectWithTag("level 2");
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            if (level1 == true)
            {
                
                
                Destroy (BlueLevel);
                Instantiate(Green);

                level1 = false;
                level2 = true;
                level3 = false;
            }
           else
            
            if (level2 == true)
            {
                
                Destroy(GreenLevel);
                Instantiate(Red);
                level1 = false;
                level2 = false;
                level3 = true;
            }
            else
                
            if (level3 == true)
            {

                Destroy(RedLevel);
                Instantiate(Blue);
                level1 = true;
                level2 = false;
                level3 = false;
            }
        }
    }
}
