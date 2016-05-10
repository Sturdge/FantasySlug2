using UnityEngine;
using System.Collections;

public class AttackState : IPlayerState {

	private readonly StatePatternPlayer player;

    private float timer;

    public AttackState (StatePatternPlayer statePatternPlayer)
    {

        player = statePatternPlayer;

        timer = 0;

    }

    public void updateState()
    {

        //animation
        if (!player.GetComponent<Animator>().GetBool("isAttacking"));
            toIdleState();

    }

    public void OnTriggerEnter(Collider other)
    {


    }

    public void toMoveState()
    {

        player.currentState = player.moveState;

    }

    public void toIdleState()
    {

        player.currentState = player.idleState;

    }

    public void toAttackState()
    {

        Debug.Log( "AttackState.cs: You're already in Attack State!" );

    }
}
