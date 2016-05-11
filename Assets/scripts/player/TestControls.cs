using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class TestControls : MonoBehaviour {

    static Animator anim; // holds the animator controller for the player. 
    public float speed = 10.0f; // holds the speed the player can move. 
    int attackvalue; // used to determin what attack the player will use when the left mouse button is pressed. 
    public GameObject fireBall; // holds the fire ball object. 
    public Transform fireBallSpawn; // Holds the spawn location of the fire ball.
    private int manacost; // How much mana it cost to use the fireball spell. 

	// Use this for initialization
	void Start () {

       
        anim = GetComponent<Animator>(); //anim is the controller of the player.
	}
	
	// Update is called once per frame
	void Update () {

      

        if(Input.GetMouseButtonDown(2)) // if the middle mouse button is pressed.
        {

            if (StatePatternPlayer.mana > 10) // And the player has more than 10 mana.
            {
                anim.SetTrigger("isCasting"); // Play the casting animation
                Instantiate(fireBall, fireBallSpawn.position, fireBallSpawn.rotation); // shoot a fireball.
                manacost = 10; // The manacost of the fire is 10.
                StatePatternPlayer.mana -= 10; // take this aways from the players mana pool.
            }
        }
        
        float translation = Input.GetAxis("Horizontal") * speed;      
        translation *= Time.deltaTime;                              // controlls the players movement.
        transform.Translate(0, 0, translation);


        if (Input.GetMouseButtonDown(0)) // if the left mouse button is pressed.
        {

            Debug.Log("The Player has attacked"); // The player has attacked.
            anim.SetBool("isAttacking", true); // The player is now attacking.
            anim.SetBool("isIdle", false); // The player is no longer idle.
           if( anim.GetBool("isAttacking")== true) // if the player is attacking.
            {
                float i;

                i = UnityEngine.Random.Range(1f, 3f);

                attackvalue = Convert.ToInt32(i); // Perform one of the following 3 attack animations. 
                switch(attackvalue)
                {
                    case 1:

                {

                            anim.SetTrigger("isAttack1");


                            break;


                }
                    case 2:
                        {

                            anim.SetTrigger("isAttack2");


                            break;

                        }
                    case 3:
                        {

                            anim.SetTrigger("isAttack3");




                            break;

                        }


                }

            }
        }
        else // otherwise
        {

            anim.SetBool("isAttacking", false); // The player is not attacking.
            anim.SetBool("isIdle", true); // The player is idle.
        }


        if(Input.GetMouseButtonDown(1)) // If the right mouse button is pressed.
        {

            anim.SetBool("isBlocking",true); // The player is blocking and play the blocking animation.
            
       }

        else 
        {
            anim.SetBool("isBlocking", false); // the player is not blocking.
            anim.SetBool("isIdle", true); // the player is idle. 
        }

     
         if (Input.GetButtonDown("Jump")) // If the space bar is pressed.
        {

            anim.SetTrigger("isJumping"); // Play the jumping animation. 
        }



        if (translation > 0) // if the player is pressing the D button.
        {
            anim.SetBool("isRunning", true); // The player is running and plays the running animation.
            anim.SetBool("isIdle", false); // The player is not idle.


        }
        else // Otherwise 
        {
            anim.SetBool("isRunning", false); // The player isnt running.
            anim.SetBool("isIdle", true); // The player is idle. 
        }

    
        
           if(Input.GetKeyDown("q")) // If the player presses the Q button.
        {

                transform.Rotate(new Vector3(0, 180, 0)); // Rotate the player
               

        }
    }
}
