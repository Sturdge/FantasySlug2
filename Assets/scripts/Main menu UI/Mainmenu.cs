using UnityEngine;
using System.Collections;

public class Mainmenu : MonoBehaviour {

    public Camera mainMenu; // Holds the main menu camera. 
    public Camera options; // Holds the options menu camera.
    public Camera highscore; // Holds the highscore menu camera.
    public Camera Credits; // Holds the credits menu camera.
    public GameObject mainMenuCanvas; // Holds the main menus canvas.
    public GameObject optionsCanvas; // Holds the options mennu canvas. 
    public GameObject highScoreCanvas; // Holds the high score menu canvas. 
    public GameObject levelSelectCanvas; // Holds the level select canvas. 
    public GameObject creditsScreenCanvas; // Holds the credits screen canvas.
    public Camera levelSelect; // holds the level select camers.
    public string level1; // holds the name of the 1st level
    public string Tutorial; // holds the name of the turtorial level.
    bool isMute; // A bool used to mute the game. 
   
	// Use this for initialization
	void Start()
    {
        mainMenu.enabled = true; // main menu camera is turned on.
        mainMenuCanvas.SetActive(true); // main menu canvas is showing. 
        Application.targetFrameRate = 60;
        // All over cameras and canvas are turned off.
        Screen.SetResolution(1024, 768, false, 60);
        options.enabled = false;
        optionsCanvas.SetActive(false);      
        highscore.enabled = false;
        highScoreCanvas.SetActive(false);
        levelSelect.enabled = false;
        levelSelectCanvas.SetActive(false);
        Credits.enabled = false;
        creditsScreenCanvas.SetActive(false);
        
    }


    public void lowerQuality() // Function for the lower quality button on the options menu.
    {

        QualitySettings.DecreaseLevel(true); // Lower the quality of the game. 
    }

    public void raiseQuality() // Function for the raise quality button on the options menu. 
    {

        QualitySettings.IncreaseLevel(true); // Raise the quality of the game. 

    }


    public void Mute() // Mute button function in the options menu.
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1; // Turns the games sound off and on when pressed.



    }
    public void Options() // Function for the options button on the main menu.
    {
        // Enables of the options menu camera and canvas.
        options.enabled = true;
        optionsCanvas.SetActive(true);
        // Turns all others off.
        mainMenu.enabled = false;
        mainMenuCanvas.SetActive(false);
        levelSelect.enabled = false;
        levelSelectCanvas.SetActive(false);
        highscore.enabled = false;
        highScoreCanvas.SetActive(false);
        Credits.enabled = false;
        creditsScreenCanvas.SetActive(false);
    }

   
    public void LoadLevel1() // Function for the level 1 button on the level select. 
    {
        Application.LoadLevel(level1); // load level 1. 


    }

    public void LoadLevelTutorial() // Function for the tutorial button on the level select. 
    {
        Application.LoadLevel(Tutorial); // Load the tutorial level. 


    }

    public void HighScore() // Function for the high score button on the main menu.
    {
        // Turn the high score camera and canvas on.
        highscore.enabled = true;
        highScoreCanvas.SetActive(true);
        // Turn all others off. 
        mainMenu.enabled = false;
        options.enabled = false;
        optionsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(false);      
        levelSelect.enabled = false;
        levelSelectCanvas.SetActive(false);
        Credits.enabled = false;
        creditsScreenCanvas.SetActive(false);

    }

    public void PlayGame() // Function for the play game button on the main menu. 
    {
        // Turn the level select camera and canvas on. 
        levelSelect.enabled = true;
        levelSelectCanvas.SetActive(true);
        // Turn all others off. 
        mainMenu.enabled = false;
        options.enabled = false;
        optionsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(false);
        highscore.enabled = false;
        highScoreCanvas.SetActive(false);
        Credits.enabled = false;
        creditsScreenCanvas.SetActive(false);
    }

    public void CreditsScreen() // Function for the credit button on the main menu. 
    {
        // Enable the credits menu camera and canvas.
        Credits.enabled = true;
        creditsScreenCanvas.SetActive(true);
        // Turn all others off. 
        levelSelect.enabled = false;
        levelSelectCanvas.SetActive(false);
        mainMenu.enabled = false;
        options.enabled = false;
        optionsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(false);
        highscore.enabled = false;
        highScoreCanvas.SetActive(false);       
      


    }
   public void QuitGame() // Function for the quit button on the main menu.
    {
        Application.Quit(); // Quit the application.

    }

    public void BackToMenu() // Function for the back to menu button that appears on various elements of the main menu.
    {
        // Enable the main menu camera and canvas.
        mainMenu.enabled = true;
        mainMenuCanvas.SetActive(true);
        //Turn all others off. 
        options.enabled = false;
        optionsCanvas.SetActive(false);        
        highscore.enabled = false;
        highScoreCanvas.SetActive(false);
        levelSelect.enabled = false;
        levelSelectCanvas.SetActive(false);
        Credits.enabled = false;
        creditsScreenCanvas.SetActive(false);

    }
}
