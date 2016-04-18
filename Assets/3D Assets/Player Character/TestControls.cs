using UnityEngine;
using System.Collections;
using System;

public class TestControls : MonoBehaviour {

    static Animator anim;
    public float speed = 10.0f;
    int attackvalue;
    

	// Use this for initialization
	void Start () {


        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {



        
        float translation = Input.GetAxis("Vertical") * speed;      
        translation *= Time.deltaTime;   
        transform.Translate(0, 0, translation);


        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("The Player has attacked");
            anim.SetBool("isAttacking", true);
            anim.SetBool("isIdle", false);
           if( anim.GetBool("isAttacking")== true)
            {
                float i;

                i = UnityEngine.Random.Range(1f, 3f);

                attackvalue = Convert.ToInt32(i);
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
        else
        {

            anim.SetBool("isAttacking", false);
            anim.SetBool("isIdle", true);
        }


        if(Input.GetMouseButtonDown(1))
        {

            anim.SetBool("isBlocking",true);
            
       }

        else
        {
            anim.SetBool("isBlocking", false);
            anim.SetBool("isIdle", true);
        }

     
         if (Input.GetButtonDown("Jump"))
        {

            anim.SetTrigger("isJumping");
        }



        if(translation != 0)
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isIdle", false);


        }
        else
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", true);
        }


	}
}
