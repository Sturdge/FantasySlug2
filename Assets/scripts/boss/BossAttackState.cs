using UnityEngine;
using System.Collections;

public class BossAttackState : IBossState {

    private readonly StatePatternBoss boss;

    public BossAttackState ( StatePatternBoss statePatternBoss )
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
