using UnityEngine;
using System.Collections;

public class Iconmanager : MonoBehaviour
{
    public GameObject invIcon; // Holds the icon the will be displayed when the player picks up invincibility. 
    float invtimer = 0.0f; // create a float for the timer inviniciblity is active.
    float invMaxTime = 5.0f; // Create a float with the value of the length invincibility lasts.
    public GameObject InvincibilityPickUp;



    // Use this for initialization
    void Start()
    {

        invIcon.SetActive(false); // Icon does not appear on screen.
    }

    // Update is called once per frame
    void Update()
    {



        if (Invincibility.pickedup == true) // if an invincibility buff has been picked up.
        {
            invtimer += Time.deltaTime; // start the timer. 
            Debug.Log(invtimer);
            Debug.Log(Invincibility.pickedup);
            invIcon.SetActive(true); // make the icon display.
        }




            if(invtimer >= invMaxTime) // when invincibility has run its duration. 
            {

                invIcon.SetActive(false); // turn of the icon.
                Invincibility.pickedup = false; // the player has no longer picked up invincibility. 
                invtimer = 0; // reset the timer. 
            }

        
    }
}
       




	
   

               
                          
                

            
        
    

