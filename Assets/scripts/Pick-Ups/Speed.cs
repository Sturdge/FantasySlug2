using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour
{

   
    public GameObject SpeedPickUp;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            if (SpeedPickUp.tag == "Speed")
            {


                Debug.Log("player has picked up Speed buff");
                Debug.Log("The players is faster for 10 secs");
                Destroy(gameObject);

            }
        }
    }
}
