using UnityEngine;

public class GameManager : MonoBehaviour

{
    public GameObject startScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
         startScreen.SetActive(true);
    }

    // Update is called once per frame
   
    public void StartGame()
    {
        startScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}
