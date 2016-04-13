using UnityEngine;
using System.Collections;

public class BossSpecialState : IBossState {

    private readonly StatePatternBoss boss;

    public BossSpecialState ( StatePatternBoss statePatternBoss )
    {

        boss = statePatternBoss;

    }

    public void updateState() { }

    public void OnTriggerEnter(Collider other) { }

    public void toIdleState() { }

    public void toAttackState() { }

    public void toMoveState() { }

    public void toSpecialState() { }
}
