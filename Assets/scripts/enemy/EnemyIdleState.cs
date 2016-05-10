using UnityEngine;
using System.Collections;

public class EnemyIdleState : IEnemyState
{

    private readonly StatePatternEnemy enemy;

    private RaycastHit hit;

    public EnemyIdleState ( StatePatternEnemy statePatternEnemy )
    {

        enemy = statePatternEnemy;

    }

    public void updateState()
    {

        if( Physics.Raycast(enemy.transform.position, -enemy.transform.right, out hit, 3) )
        {

            if(hit.collider.gameObject.tag == "Player")
            {

                toMoveState();

            }

        }

    }

    public void toIdleState()
    {

        Debug.Log("EnemyIdleState: You're already in IdleState");

    }

    public void toAttackState()
    {

        enemy.currentState = enemy.attackState;

    }

    public void toMoveState()
    {

        enemy.currentState = enemy.moveState;

    }

}
