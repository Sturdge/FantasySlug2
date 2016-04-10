using UnityEngine;
using System.Collections;

public class BossSpecialState : IBossState {

    private readonly StatePatternBoss boss;

    public BossSpecialState ( StatePatternBoss statePatternBoss )
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
