using UnityEngine;
using System.Collections;

public class HealthPotion : MonoBehaviour
{

    public int healthregained = 25;
    public GameObject hpPotion;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            if (hpPotion.tag == "HealthPotion")
            {


                Debug.Log("player has picked up health potion");
                Debug.Log("The players health was" + StatePatternPlayer.health + " and will now increase by 25");
                StatePatternPlayer.health += healthregained;
                Debug.Log("the players health is now" + StatePatternPlayer.health);
                Destroy(gameObject);


            }

          
        }
    }
}