using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{

   
    public GameObject DamagePickUp; // Holds the damage buff object.

    void OnTriggerEnter(Collider col) // If an object collides with the damage buff.
    {
        if (col.tag == "Player") // and its the player.
        {

            if (DamagePickUp.tag == "Damage") 
            {
                Debug.Log("player has picked up Damage buff"); // The player has picked up the damage buff. 
                Debug.Log("The players is stronger for 15 secs"); // The player has the damage buff for 15 seconds.
                Destroy(gameObject); // destory the damage buff. 
            }
        }
    }
}
