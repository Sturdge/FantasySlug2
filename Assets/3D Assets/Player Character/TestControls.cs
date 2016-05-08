using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class TestControls : MonoBehaviour {

    static Animator anim;
    public float speed = 10.0f;
    int attackvalue;
    public GameObject fireBall;
    public Transform fireBallSpawn;
    private int manacost;

	// Use this for initialization
	void Start () {

       
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

      

        if(Input.GetMouseButtonDown(2))
        {

            if (StatePatternPlayer.mana > 10)
            {
                anim.SetTrigger("isCasting");
                Instantiate(fireBall, fireBallSpawn.position, fireBallSpawn.rotation);
                manacost = 10;
                StatePatternPlayer.mana -= 10;
            }
        }
        
        float translation = Input.GetAxis("Horizontal") * speed;      
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



        if (translation > 0)
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isIdle", false);


        }
        else
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", true);
        }

            if (translation < 0)
            {


            
                anim.SetBool("isRunningBack", true);
                anim.SetBool("isIdle", false);


            }
            else
            {
                anim.SetBool("isRunningBack", false);
                anim.SetBool("isIdle", true);
            }
        
           if(Input.GetKeyDown("a"))
        {

                transform.Rotate(new Vector3(0, 180, 0));
               transform.Translate(0, 0, -translation);

        }
    }
}
