using UnityEngine;
using System.Collections;

public class IdleState : IPlayerState {

	private readonly StatePatternPlayer player;

    public IdleState (StatePatternPlayer statePatternPlayer)
    {

        player = statePatternPlayer;

    }

    public void updateState()
    {

        getInput();

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

        Debug.Log( "IdleState.cs: You're already in Idle State!" );

    }

    public void toAttackState()
    {

        player.currentState = player.attackState;

    }

    void getInput()
    {

        if (Input.GetKey(KeyCode.A))
            toMoveState();
        else if (Input.GetKey(KeyCode.D))
            toMoveState();
        else if (Input.GetKey(KeyCode.Space))
            toMoveState();
        //else if (Input.GetMouseButtonDown(0))
            //toAttackState();

    }

}
