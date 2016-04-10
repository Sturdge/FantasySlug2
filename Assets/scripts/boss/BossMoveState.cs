using UnityEngine;
using System.Collections;

public class BossMoveState : IBossState {

    private readonly StatePatternBoss boss;

    public BossMoveState ( StatePatternBoss statePatternBoss )
    {

        boss = statePatternBoss;

    }

    void updateState() { }

    void OnTriggerEnter(Collider other) { }

    void toIdleState() { }

    void toAttackState() { }

    void toMoveState() { }

    void toSpecialState() { }
}
