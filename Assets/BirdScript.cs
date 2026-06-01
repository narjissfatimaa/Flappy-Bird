using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D My_Rigidbody;
    public float flapStrength;
    public LogicManager logic;
    public bool birdIsAlive = true;
    public GameManager GameManager;
    
    void Start()
    {
        if (transform.position.y < -6f)
        {
            logic.gameOver();
        }

        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
   
    void Update()
    {
        
     
        if (Keyboard.current.spaceKey.wasPressedThisFrame==true && birdIsAlive==true)
        {
            My_Rigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
