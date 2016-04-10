using UnityEngine;
using System.Collections;
using System;

public class BossIdleState : IBossState {

    private readonly StatePatternBoss boss;

    private int rngResult;

    private System.Random rng = new System.Random();

    private float timer;

    public BossIdleState ( StatePatternBoss statePatternBoss )
    {

        boss = statePatternBoss;

    }

    void Start()
    {

        timer = 0;

    }

    void updateState()
    {

        if (timer < 5)
            timer += Time.deltaTime;
        else
        {

            rngResult = rng.Next(0, 2);

            timer = 0;

            switch( rngResult )
            {

                case 0:

                    toMoveState();
                    break;

                case 1:

                    toAttackState();
                    break;

                case 2:
                    toSpecialState();
                    break;

                default:

                    toAttackState();
                    break;

            }

        }


    }

    void toIdleState()
    {

        Debug.Log( "BossIdleState.cs: You're already in Idle State!" );

    }

    void toAttackState()
    {

        boss.currentState = boss.attackState;

    }

    void toMoveState()
    {

        boss.currentState = boss.moveState;

    }

    void toSpecialState()
    {

        boss.currentState = boss.specialState;

    }

    void OnTriggerEnter( Collider other )
    {



    }

}
