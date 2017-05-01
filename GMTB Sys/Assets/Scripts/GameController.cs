using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    // Create Singleton instance
    public static GameController instance;

    // Game Over controls
    public GameObject gameOverScreen;

    //BATTERY TESTING
    public GameObject battery;

    public bool gameOver = false;

    // Scrolling background control, accessable via the static instance.
    public float scrollSpeed = -1.5f;

	// Use this for initialization
	void Awake ()
    {
        // Destroy self instance if another instance exists
		if (instance == null)
        {
            instance = this;
        }   else if (instance != this)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {

        // Reload current scene if player clicks after a game over
        if (gameOver && Input.GetMouseButtonDown(0))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

    public void PlayerDied()
    {
        gameOverScreen.SetActive(true);
        gameOver = true;
    }
}
