using UnityEngine;
using System.Collections;

public class EnemyAttackState : IEnemyState {

    private readonly StatePatternEnemy enemy;

    private float timer;

    private Vector3 playerPos;

    [SerializeField]
    private int attackDelay;

    public EnemyAttackState ( StatePatternEnemy statePatternEnemy )
    {

        enemy = statePatternEnemy;

        timer = 0;

    }

    public void updateState()
    {

        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;

        if (enemy.transform.position.x - playerPos.x <= 5 && enemy.transform.position.x - playerPos.x > 1)
        {

            toMoveState();

        }
        else if (enemy.transform.position.x - playerPos.x <= 1f)
        {

            if (timer < attackDelay)
            {

                timer += Time.time;

            }
            else
            {

                //attack animation

                timer = 0;

            }

        }
        else
            toIdleState();

    }

    public void toIdleState()
    {

        enemy.currentState = enemy.idleState;

    }

    public void toAttackState()
    {

    }

    public void toMoveState()
    {

        enemy.currentState = enemy.moveState;

    }

}
