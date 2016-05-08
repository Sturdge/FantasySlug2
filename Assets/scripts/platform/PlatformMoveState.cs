using UnityEngine;
using System.Collections;

public class PlatformMoveState : IPlatformState {

	private readonly StatePatternPlatform platform;

    bool raycasting;

    public PlatformMoveState (StatePatternPlatform statePatternPlatform)
    {

        platform = statePatternPlatform;

    }

    public void updateState()
    {

        if (checkPlayerAbove ()) 
        {

            raycasting = false;

			switch (platform.platformType) {

			case 0:
				platform.rigid.useGravity = true;
				platform.rigid.isKinematic = false;
				break;

			case 1:
				if (platform.currentPos == platform.originalPos) {

					platform.transform.position = Vector3.Lerp (platform.originalPos, platform.targetPos, Time.deltaTime);
					platform.currentPos = platform.targetPos;
							
				} else if (platform.currentPos == platform.targetPos) {
					platform.transform.position = Vector3.Lerp (platform.targetPos, platform.originalPos, Time.deltaTime);
					platform.currentPos = platform.originalPos;
				}
				break;

			}

		}
		else if (!checkPlayerAbove())
			toIdleState ();

    }

    public bool checkPlayerAbove()
    {

        if(raycasting)
        { 
		    if(Physics.Raycast(platform.transform.position, Vector3.up, 5))
			    return true;
		    else
			    return false;
        }

        return false;

    }

    public void toMoveState()
    {

        Debug.Log( "MovementState.cs: You are already in Movement State!" );

    }

    public void toIdleState()
    {

        platform.currentState = platform.idleState;

    }

}
