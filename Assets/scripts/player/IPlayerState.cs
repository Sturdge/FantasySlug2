using UnityEngine;
using System.Collections;

public interface IPlayerState
{

    void updateState();

    void OnTriggerEnter(Collider other);

    void toMoveState();

    void toIdleState();

    void toAttackState();

}
