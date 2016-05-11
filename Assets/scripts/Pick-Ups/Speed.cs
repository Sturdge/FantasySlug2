using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour
{

   
    public GameObject SpeedPickUp; // Hold the speed buff object. 
    void OnTriggerEnter(Collider col) // if an object collides with the speed buff.
    {
        if (col.tag == "Player") // and its the player.
        {

            if (SpeedPickUp.tag == "Speed")
            {


                Debug.Log("player has picked up Speed buff"); // The player has picked up the Speed buff. 
                Debug.Log("The players is faster for 10 secs");
                Destroy(gameObject); // Destroy the speed buff. 

            }
        }
    }
}
