using UnityEngine;
using System.Collections;

public class HealthPotion : MonoBehaviour
{

    public int healthregained = 25; // holds the amount of health regained when the health potion is picked up.
    public GameObject hpPotion; // holds the health potions object. 
    void OnTriggerEnter(Collider col) // when an object colldes with the healthpotion.
    {
        if (col.tag == "Player") // and its the player.
        {

            if (hpPotion.tag == "HealthPotion")
            {


                Debug.Log("player has picked up health potion"); // the player has picked up a health potion. 
                Debug.Log("The players health was" + StatePatternPlayer.health + " and will now increase by 25");
                StatePatternPlayer.health += healthregained; // give the player the regained health.
                Debug.Log("the players health is now" + StatePatternPlayer.health);
                Destroy(gameObject); // destroy the health potion. 


            }

          
        }
    }
}