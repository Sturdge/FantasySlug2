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

        Debug.DrawLine(enemy.rC.transform.position, enemy.rC.transform.forward, Color.red);

        if( Physics.Raycast(enemy.rC.transform.position, -enemy.
            rC.transform.right, out hit, 3) )
        {

            if(hit.collider.gameObject.tag == "Player")
            {

                Debug.Log("raycast hit");

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
