using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //variable can be access through out all sctipts to see if the game is paused 
    public static bool GameIsPaused = false;

    // referances the pause menu 
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        // If the Escape key is paused then.... 
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            // Resume the game if the game is paused 
            if(GameIsPaused)
            {
                // calls the Resume function
                Resume();
            }
            // otherwise pause the game
            else
            {
                //calls the Pause function 
                Pause();
            }
        }
    }

    public void Resume()
    {
        //sets the PauseMenuUi object to false 
        pauseMenuUI.SetActive(false);
        //Resumes time to the normal rate 
        Time.timeScale = 1f;
        //sets the GameIsPaused variable to false
        GameIsPaused = false;
    }
   public void Pause()
   {
        // sets the PauseMenuUI object to true
        pauseMenuUI.SetActive(true);
        // freezes the game 
        Time.timeScale = 0f;
        //sets the GameIsPaused variable to true 
        GameIsPaused = true;
   }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("loading Menu");
        SceneManager.LoadScene("Main Menu");
    }
}
