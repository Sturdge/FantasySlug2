using UnityEngine;
using System.Collections;

public class ManaPotion : MonoBehaviour
{
    public int manaregained = 25;
    public GameObject mPotion;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (mPotion.tag == "ManaPotion")
            {

                Debug.Log("player has picked up Mana potion");
                Debug.Log("The players Mana was" + StatePatternPlayer.mana + " and will now increase by 25");
                StatePatternPlayer.mana += manaregained;
                Debug.Log("the players mana is now" + StatePatternPlayer.mana);
                Destroy(gameObject);


            }
        }
    }
}