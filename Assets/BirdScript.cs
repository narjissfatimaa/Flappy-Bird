using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D My_Rigidbody;
    public float flapStrength;
    public LogicManager logic;
    public bool birdIsAlive = true;
    public GameManager GameManager;
    public AudioClip jumpSound;
    public AudioClip collideSound;
    private AudioSource audioSource;
   

    void Start()
    {
       
        audioSource = GetComponent<AudioSource>();
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
            playJumpSound();
        }
        
    }
    
    public void collidePipeSound()
    {
        audioSource.PlayOneShot(collideSound);
    }
    public void onCollisionEnter2D( Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            collidePipeSound();
            logic.gameOver();
            birdIsAlive = false;
        }
    }
    public void playJumpSound()
    {
        audioSource.PlayOneShot(jumpSound);
    }
}
