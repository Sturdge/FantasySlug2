using UnityEngine;
using System.Collections;

public class scoreManager : MonoBehaviour {

    public static int score; // Create a public static int to hold the score.
    public static int Highscore = 0; // int to hold the highscore. 

    public GUIText scoreText; // Public GUIText to hold the on screen text. 


    void Awake()
    {
        scoreText = GetComponent<GUIText>(); // Get the text that will be displayed on screen. 
        score = 0; // Score is set to 0


    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        scoreText.text = "score " + score + ""; // Set the text to be displayed on screen, 

       
    }
}