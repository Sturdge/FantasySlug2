using UnityEngine;
using System.Collections;

public class StatePatternBoss : MonoBehaviour {

    [HideInInspector]
    public IBossState currentState;

    [HideInInspector]
    public BossIdleState idleState;

    [HideInInspector]
    public BossMoveState moveState;

    [HideInInspector]
    public BossAttackState attackState;

    [HideInInspector]
    public BossSpecialState specialState;

    private void Awake()
    {

        idleState = new BossIdleState(this);
        moveState = new BossMoveState(this);
        specialState = new BossSpecialState(this);
        attackState = new BossAttackState(this);

    }

    void Start()
    {

        currentState = idleState;

    }

    void Update()
    {

        currentState.updateState();

    }
}
