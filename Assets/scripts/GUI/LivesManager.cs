using UnityEngine;
using System.Collections;

public class LivesManager : MonoBehaviour {

    public static int lives; // Create a public static int to hold the score.

    public GUIText livesText; // Public GUIText to hold the on screen text. 


    void Awake()
    {
        livesText = GetComponent<GUIText>(); // Get the text that will be displayed on screen. 
        lives = 5; // Score is set to 0


    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        livesText.text = ": " + lives + ""; // Set the text to be displayed on screen, 


    }
}
