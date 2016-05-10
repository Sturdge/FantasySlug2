using UnityEngine;
using System.Collections;

public class Invincibility : MonoBehaviour
{

    public GameObject InvincibilityPickUp;
    static public bool pickedup = false;
   

    void Start()
    {

    

    }

   
    
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            if (InvincibilityPickUp.tag == "Invin")
            {
                pickedup = true;
                transform.position = new Vector3(200, 200, 200);
                                            
                }
            }
        }
      
    }

   

    


