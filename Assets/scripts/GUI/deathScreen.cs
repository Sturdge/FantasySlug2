using UnityEngine;
using System.Collections;

public class deathScreen : MonoBehaviour {


    public string mainmenu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BackToMenu()
    {

        Application.LoadLevel(mainmenu);

    }


     public void exitGame()
    {

        Application.Quit();


    }
}
