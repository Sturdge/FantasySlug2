using UnityEngine;
using System.Collections;

public class MoveState : IPlayerState {

    private readonly StatePatternPlayer player;

    private RaycastHit hit;

    public MoveState (StatePatternPlayer statePatternPlayer)
    {

        player = statePatternPlayer;

    }

    public void updateState()
    {

        move();

        Debug.DrawLine(player.transform.position, new Vector3( player.transform.position.x, player.transform.position.y -1.25f, player.transform.position.z ), Color.red);

    }

    public void OnTriggerEnter(Collider other)
    {

    }

    public void toMoveState()
    {

        Debug.Log("MoveState.cs: You're already in Move State!");

    }

    public void toIdleState()
    {

        player.currentState = player.idleState;

    }

    public void toAttackState()
    {

        player.currentState = player.attackState;

    }

    void move()
    {

        if( Input.GetKey(KeyCode.A) )
            player.GetComponent<Rigidbody>().MovePosition( player.transform.position - player.transform.right * Time.deltaTime * 5);
        else if( Input.GetKey(KeyCode.D) )
            player.GetComponent<Rigidbody>().MovePosition(player.transform.position + player.transform.right * Time.deltaTime * 5);

        if (Input.GetKeyUp(KeyCode.A))
            toIdleState();
        else if (Input.GetKeyUp(KeyCode.D))
            toIdleState();

		if(Input.GetKeyDown (KeyCode.Space))
        {

            if (!player.jumping)
            {
                player.GetComponent<Rigidbody>().AddForce(Vector3.up * player.jumpforce, ForceMode.Impulse);
               
                player.jumping = true;
            }

        }
        
    }

    

}
