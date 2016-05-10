using UnityEngine;
using System.Collections;

public class Invincibility : MonoBehaviour
{

    public GameObject InvincibilityPickUp;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            if (InvincibilityPickUp.tag == "Invin")
            {
                Debug.Log("player has picked up Invincibility buff");
                Debug.Log("The players is now invincible for 5 secs");
                Destroy(gameObject);
            }
        }
    }
}

