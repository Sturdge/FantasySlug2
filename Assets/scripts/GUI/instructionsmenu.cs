using UnityEngine;
using System.Collections;

public class instructionsmenu : MonoBehaviour
{


    public GameObject gameInstructionsCanvas; // holds the menu for the game instructions.
    public GameObject uiInstructions; // holds the menu for the UI instructions.
    public string backToMenu; // holds the level name of the main menu.
    public string tutorial; // holds the level name of the tutorial level.

    // Use this for initialization
    void Start()
    {

        gameInstructionsCanvas.SetActive(true); // set the game instructions to active. 
        uiInstructions.SetActive(false); // set the ui instructions to inactive.

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void backTomenu() // when the back to menu button is pressed.
    {


        Application.LoadLevel(backToMenu); // load the main menu.

    }

    public void nextPage() // when the next page button is pressed.
    {

        gameInstructionsCanvas.SetActive(false); // turn the game instructions off.
        uiInstructions.SetActive(true); // display the ui instructions.


    }

    public void previousPage() // when the previous page button is pressed.
    {
        uiInstructions.SetActive(false); // set the ui instructions to false.
        gameInstructionsCanvas.SetActive(true); // set the game instructions to acive. 


    }

    public void continueToGame() // when the continue to game button is pressed.
    {

        Application.LoadLevel(tutorial); // load the tutorial level. 

    }



}
