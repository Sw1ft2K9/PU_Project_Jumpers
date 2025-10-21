using UnityEngine;

public class kill : MonoBehaviour
{
    public float deadzone = -15;
    public GameObject start;
    public deathScript deathScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadzone)
        {
            gameObject.transform.position = start.transform.position;
            deathScript.addScore(1);
            GetComponent<Rigidbody2D>().linearVelocity= Vector2.zero;
        }
    }
    

}
