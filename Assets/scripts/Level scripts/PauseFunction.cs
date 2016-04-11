using UnityEngine;
using System.Collections;

public class PauseFunction : MonoBehaviour
{

    public GameObject pauseMenu; // create a public gameobject to hold the pause menu
    public bool paused; // Create a bool to determin if the game is paused. 
    public string backToMenu; // Create a string to hold the required level. 

    // Use this for initialization
    void Start()
    {
        paused = false; // Paused is set as false.

    }

    // Update is called once per frame
    void Update()
    {

        if (paused)
        {
            pauseFunction(true); // is the game is paused then run this method
        }
        else
        {
            pauseFunction(false); // if it is not run this method. 
        }

        if (Input.GetKeyDown("p")) // If the P button is pressed.
        {
            pauseButton(); // run the pauseButton method. 


        }




    }

    void pauseFunction(bool gameState)
    {
        if (gameState == true) // If the game is paused
        {
            pauseMenu.SetActive(true); // bring up the pause menu
            Time.timeScale = 0.0f; // set the time scale to 0 and pause the game. 
        }
        else // otherwise
        {
            Time.timeScale = 1.0f; // unpause the game
            pauseMenu.SetActive(false); // get rid of the pause menu. 
        }
    }

    public void pauseButton() // pause button method. 
    {
        if (paused == true) // if the game is paused. 
        {
            paused = false;  // creates a toggle function for the pause menu, unpause the game. 
        }
        else //Otherwise
        {
            paused = true; // pause the game. 
        }

    }
    public void BackToMenu() // if the back to menu button is pressed
    {
        Time.timeScale = 1.0f; // set the time scael back to 1
        Application.LoadLevel(backToMenu); // load the main menu. 
    }

    public void ExitGame() // if the exitgame button is pressed.
    {

        Application.Quit(); // quit the application.

    }

}
