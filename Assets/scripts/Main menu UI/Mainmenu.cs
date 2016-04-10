using UnityEngine;
using System.Collections;

public class Mainmenu : MonoBehaviour {

    public Camera mainMenu;
    public Camera options;
    public Camera highscore;
    public GameObject mainMenuCanvas;
    public GameObject optionsCanvas;
    public GameObject highScoreCanvas;
    public GameObject levelSelectCanvas;
    public Camera levelSelect;
    public string level1;
   
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
    }

    public void LoadLevel1()
    {
        Application.LoadLevel(level1);


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

    }
}
