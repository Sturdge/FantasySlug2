using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

   

    public GUIText levelText; // Public GUIText to hold the on screen text. 


    void Awake()
    {
        levelText = GetComponent<GUIText>(); // Get the text that will be displayed on screen. 
  


    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        levelText.text = "Level: " + StatePatternPlayer.level; // Set the text to be displayed on screen, 


    }
}
