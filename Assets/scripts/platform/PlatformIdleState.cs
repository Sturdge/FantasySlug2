using UnityEngine;
using System.Collections;

public class PlatformIdleState : IPlatformState {

    private readonly StatePatternPlatform platform;

    public PlatformIdleState (StatePatternPlatform statePatternPlatform)
    {

        platform = statePatternPlatform;

    }

    public void updateState()
    {

        if ( checkPlayerAbove() )
            toMoveState();

    }

    public bool checkPlayerAbove()
    {

		if(Physics.Raycast(platform.transform.position, Vector3.up, 5))
			return true;
		else
        	return false;

    }

    public void toMoveState()
    {

        platform.currentState = platform.moveState;

    }

    public void toIdleState()
    {

        Debug.Log("StationaryState.cs: You are already in Idle State!");

    }
}
