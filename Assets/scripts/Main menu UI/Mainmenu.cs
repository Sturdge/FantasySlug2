using UnityEngine;
using System.Collections;

public class Mainmenu : MonoBehaviour {

    public PlayerCamera mainMenu;
    public PlayerCamera options;
    public PlayerCamera highscore;
    public PlayerCamera Credits;
    public GameObject mainMenuCanvas;
    public GameObject optionsCanvas;
    public GameObject highScoreCanvas;
    public GameObject levelSelectCanvas;
    public GameObject creditsScreenCanvas;
    public PlayerCamera levelSelect;
    public string level1;
    public string Tutorial;
    bool isMute;
   
	// Use this for initialization
	void Start()
    {
        mainMenu.enabled = true;
        mainMenuCanvas.SetActive(true);
        options.enabled = false;
        optionsCanvas.SetActive(false);      
        highscore.enabled = false;
        highScoreCanvas.SetActive(false);
        levelSelect.enabled = false;
        levelSelectCanvas.SetActive(false);
        Credits.enabled = false;
        creditsScreenCanvas.SetActive(false);
        
    }


    public void lowerQuality()
    {

        QualitySettings.DecreaseLevel(true);
    }

    public void raiseQuality()
    {

        QualitySettings.IncreaseLevel(true);

    }


    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;



    }
    public void Options()
    {
        options.enabled = true;
        optionsCanvas.SetActive(true);
        mainMenu.enabled = false;
        mainMenuCanvas.SetActive(false);
        levelSelect.enabled = false;
        levelSelectCanvas.SetActive(false);
        highscore.enabled = false;
        highScoreCanvas.SetActive(false);
        Credits.enabled = false;
        creditsScreenCanvas.SetActive(false);
    }

   
    public void LoadLevel1()
    {
        Application.LoadLevel(level1);


    }

    public void LoadLevelTutorial()
    {
        Application.LoadLevel(Tutorial);


    }

    public void HighScore()
    {
        mainMenu.enabled = false;
        options.enabled = false;
        optionsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(false);
        highscore.enabled = true;
        highScoreCanvas.SetActive(true);
        levelSelect.enabled = false;
        levelSelectCanvas.SetActive(false);
        Credits.enabled = false;
        creditsScreenCanvas.SetActive(false);

    }

    public void PlayGame()
    {
        mainMenu.enabled = false;
        options.enabled = false;
        optionsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(false);
        highscore.enabled = false;
        highScoreCanvas.SetActive(false);
        levelSelect.enabled = true;
        levelSelectCanvas.SetActive(true);
        Credits.enabled = false;
        creditsScreenCanvas.SetActive(false);
    }

    public void CreditsScreen()
    {
        mainMenu.enabled = false;
        options.enabled = false;
        optionsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(false);
        highscore.enabled = false;
        highScoreCanvas.SetActive(false);
        levelSelect.enabled = true;
        levelSelectCanvas.SetActive(true);
        Credits.enabled = true;
        creditsScreenCanvas.SetActive(true);


    }
   public void QuitGame()
    {
        Application.Quit();

    }

    public void BackToMenu()
    {

        mainMenu.enabled = true;
        mainMenuCanvas.SetActive(true);
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
