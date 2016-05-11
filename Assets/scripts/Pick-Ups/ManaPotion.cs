using UnityEngine;
using System.Collections;

public class ManaPotion : MonoBehaviour
{
    public int manaregained = 25; // Holds the amount of mana that the player will regain when the mana potion is picked up. 
    public GameObject mPotion; // Holds the mana potion object. 
    void OnTriggerEnter(Collider col) // If an object collides with the mana potion. 
    {
        if (col.tag == "Player") // and its the player. 
        {
            if (mPotion.tag == "ManaPotion")
            {

                Debug.Log("player has picked up Mana potion"); // The player has picked up the mana potion. 
                Debug.Log("The players Mana was" + StatePatternPlayer.mana + " and will now increase by 25");
                StatePatternPlayer.mana += manaregained; // Give the player mana at the value of the manaregained variable. 
                Debug.Log("the players mana is now" + StatePatternPlayer.mana);
                Destroy(gameObject); // Destory the mana potion. 


            }
        }
    }
}