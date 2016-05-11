using UnityEngine;
using System.Collections;

public class Invincibility : MonoBehaviour
{

    public GameObject InvincibilityPickUp; // Holds the invincibility pick up. 
    static public bool pickedup = false; // has the player picked up the invincibility. 
   

    void Start()
    {

    

    }

   
    
    void OnTriggerEnter(Collider col) // if an object collides with the invincibility buff.
    {
        if (col.tag == "Player") // And its the player.
        {

            if (InvincibilityPickUp.tag == "Invin")
            {
                pickedup = true; // The player has picked up the buff.
                transform.position = new Vector3(200, 200, 200); // Move the buff out of view. 
                                            
                }
            }
        }
      
    }

   

    


