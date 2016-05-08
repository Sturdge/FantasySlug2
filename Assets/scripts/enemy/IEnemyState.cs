using UnityEngine;
using System.Collections;

public interface IEnemyState
{

    void Update();

    void toIdleState();

    void toAttackState();

    void toMoveState();

}
