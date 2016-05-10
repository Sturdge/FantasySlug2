using UnityEngine;
using System.Collections;

public class EnemyMoveState : IEnemyState {

    private readonly StatePatternEnemy enemy;

    private Vector3 playerPos;

    public EnemyMoveState ( StatePatternEnemy statePatternEnemy )
    {

        enemy = statePatternEnemy;

    }

    public void updateState()
    {

        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;

        if (enemy.transform.position.x - playerPos.x <= 5 && enemy.transform.position.x - playerPos.x > 1)
        {

            enemy.GetComponent<Rigidbody>().MovePosition(enemy.transform.position - enemy.transform.right * Time.deltaTime * 2);

        }
        else if (enemy.transform.position.x - playerPos.x < 1)
        {

            toAttackState();

        }
        else
            toIdleState();

        Debug.Log(enemy.transform.position.x - playerPos.x);
        
    }

    public void toIdleState()
    {

        enemy.currentState = enemy.idleState;

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
