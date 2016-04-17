using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public static int level; // Create a public static int to hold the score.

    public GUIText levelText; // Public GUIText to hold the on screen text. 


    void Awake()
    {
        levelText = GetComponent<GUIText>(); // Get the text that will be displayed on screen. 
        level = 01; // Score is set to 0


    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        levelText.text = "Level: " + level; // Set the text to be displayed on screen, 


    }
}
