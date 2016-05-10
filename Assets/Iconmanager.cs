using UnityEngine;
using System.Collections;

public class Iconmanager : MonoBehaviour
{
    public GameObject invIcon;
    float invtimer = 0.0f;
    float invMaxTime = 5.0f;
    public GameObject InvincibilityPickUp;



    // Use this for initialization
    void Start()
    {

        invIcon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {



        if (Invincibility.pickedup == true)
        {
            invtimer += Time.deltaTime;
            Debug.Log(invtimer);
            Debug.Log(Invincibility.pickedup);
            invIcon.SetActive(true);
        }




            if(invtimer >= invMaxTime)
            {

                invIcon.SetActive(false);
                Invincibility.pickedup = false;
                invtimer = 0;
            }

        
    }
}
       




	
   

               
                          
                

            
        
    

