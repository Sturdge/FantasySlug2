using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{

   
    public GameObject DamagePickUp;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            if (DamagePickUp.tag == "Damage")
            {
                Debug.Log("player has picked up Damage buff");
                Debug.Log("The players is stronger for 15 secs");
                Destroy(gameObject);
            }
        }
    }
}
