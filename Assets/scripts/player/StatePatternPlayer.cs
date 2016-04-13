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
    public AttackState attackState;

	[HideInInspector]
	public Rigidbody rigid;

	[HideInInspector]
	public bool jumping;

    public float jumpforce;

    private void Awake()
    {

        idleState = new IdleState(this);
        moveState = new MoveState(this);
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
        checkGround();

    }

    void checkGround()
    {

        if (Physics.Raycast(transform.position, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z)))
            jumping = false;

    }


    void OnTriggerEnter( Collider other)
    {

    }


}
