using UnityEngine;

public class PipemiddleScript : MonoBehaviour
{
    public LogicManager logic;
    public BirdScript birdScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision1)
    { if (collision1.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
