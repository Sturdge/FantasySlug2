using UnityEngine;
using System.Collections;

public class Coinscript : MonoBehaviour {
    public int pointsGained = 1; // Hold the amount of points gained when picking up a coin.

    void OnTriggerEnter(Collider col) // When an object collides with the coin.
    {
        if (col.tag == "Player") // and its the player
        {
            Debug.Log("The player has picked up a coin");
            scoreManager.score += pointsGained; // add the pointsGained to the score. 
            StatePatternPlayer.XP += 1; // Adds one xp.
            Destroy(gameObject); // destroys the coin. 

        }


    }

}
