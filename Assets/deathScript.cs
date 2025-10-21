using UnityEngine;
using UnityEngine.UI;


public class deathScript : MonoBehaviour
{
    public int deathScore;
    public Text deathText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addScore(int scoreTooAdd)
    {
        deathScore = deathScore + scoreTooAdd;
        deathText.text = deathScore.ToString();
    }
}
