using UnityEngine;
using System.Collections;

public class JumpState : IPlayerState {

	private readonly StatePatternPlayer player;

    private float timer;

    public void Awake()
    {
        timer = 0;
    }

    public JumpState (StatePatternPlayer statePatternPlayer)
    {

        player = statePatternPlayer;

    }

    public void updateState()
    {

        Debug.Log(timer);

		player.rigid.AddForce (Vector3.up * 10.0f);

		player.jumping = true;

		if(player.jumping)
        {

            if (timer < 1)
                timer += Time.deltaTime;
            else
            {
                player.jumping = false;
                timer = 0;
                toIdleState();
            }

        }

    }

    public void OnTriggerEnter(Collider other)
    {


    }

	void onCollisionEnter( Collider other)
	{

		if (other.tag == "floor" || other.tag == "platform")
		{
			player.jumping = false;
		}

	}

    public void toMoveState()
    {

        player.currentState = player.moveState;

    }

    public void toIdleState()
    {

        player.currentState = player.idleState;

    }

    public void toJumpState()
    {

        Debug.Log("JumpState.cs: You're already in Jump State!");

    }

    public void toAttackState()
    {

        player.currentState = player.attackState;

    }
}
