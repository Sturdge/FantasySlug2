using UnityEngine;
using System.Collections;

public interface IEnemyState
{

    void updateState();

    void toIdleState();

    void toAttackState();

    void toMoveState();

}
