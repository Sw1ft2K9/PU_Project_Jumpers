using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public bool level1;
    public bool level2;
    public bool level3;
    public Text TextBlue;
    public Text TextGreen;
    public Text TextRed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        level1 = true;
        level2 = false;
        level3 = false;
        TextGreen.enabled = true;
        TextRed.enabled = false;
        TextBlue.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        
        if (level1 == true)
        {
            {
                    TextGreen.enabled = false;
                    TextRed.enabled = true;
                    TextBlue.enabled = false;
                    level1 = false;
                    level2 = true;
                    level3 = false;
                }

            
        }
        else

            if (level2 == true)
        {

                TextGreen.enabled = false;
                TextRed.enabled = false;
                TextBlue.enabled = true;
                level1 = false;
                level2 = false;
                level3 = true;
            }
        else

            if (level3 == true)
        {
                TextGreen.enabled = true;
                TextRed.enabled = false;
                TextBlue.enabled = false;
                level1 = true;
                level2 = false;
                level3 = false;
                   
            }
    }
}
