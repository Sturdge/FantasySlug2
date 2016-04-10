using UnityEngine;
using System.Collections;

public class StatePatternPlayer : MonoBehaviour {

    [HideInInspector]
    public IPlayerState currentState;

    [HideInInspector]
    public IdleState idleState;

    [HideInInspector]
    public MoveState moveState;

    [HideInInspector]
    public JumpState jumpState;

    [HideInInspector]
    public AttackState attackState;

	[HideInInspector]
	public Rigidbody rigid;

	[HideInInspector]
	public bool jumping;

    private void Awake()
    {

        idleState = new IdleState(this);
        moveState = new MoveState(this);
        jumpState = new JumpState(this);
        attackState = new AttackState(this);
		rigid = GetComponent<Rigidbody> ();
		jumping = false;

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
