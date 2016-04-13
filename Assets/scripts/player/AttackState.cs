using UnityEngine;
using System.Collections;

public class AttackState : IPlayerState {

	private readonly StatePatternPlayer player;

    public AttackState (StatePatternPlayer statePatternPlayer)
    {

        player = statePatternPlayer;

    }

    public void updateState()
    {


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
