using UnityEngine;
using System.Collections;

public interface IPlatformState
{

    void updateState();

    bool checkPlayerAbove();

    void toMoveState();

    void toIdleState();

}
