using UnityEngine;
using System.Collections;

public class TestControls : MonoBehaviour {

    static Animator anim;
    public float speed = 10.0f;
  

	// Use this for initialization
	void Start () {


        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {




        float translation = Input.GetAxis("Vertical") * speed;      
        translation *= Time.deltaTime;   
        transform.Translate(0, 0, translation);
     
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
