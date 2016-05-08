using UnityEngine;
using System.Collections;

public interface IBossState 
{

    void updateState();

    void OnTriggerEnter(Collider other);

    void toIdleState();

    void toAttackState();

    void toMoveState();

    void toSpecialState();

}
