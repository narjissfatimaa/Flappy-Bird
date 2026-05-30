using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D My_Rigidbody;
    public float flapStrength;
    public LogicManager logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            My_Rigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}
