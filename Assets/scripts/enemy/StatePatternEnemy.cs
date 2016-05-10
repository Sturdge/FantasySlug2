using UnityEngine;
using System.Collections;

public class StatePatternEnemy : MonoBehaviour {

    [HideInInspector]
    public IEnemyState currentState;

    [HideInInspector]
    public EnemyIdleState idleState;

   [HideInInspector]
    public EnemyAttackState attackState;

   [HideInInspector]
   public EnemyMoveState moveState;

    private void Awake()
    {

        idleState = new EnemyIdleState(this);
        
        moveState = new EnemyMoveState(this);

        attackState = new EnemyAttackState(this);

    }

    void Start()
    {

       currentState = idleState;

    }

    void Update()
    {

        currentState.updateState();

        print(currentState);
        
    }

}
