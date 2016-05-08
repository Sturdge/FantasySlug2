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

    public static int health;
    public static int mana;
    public static int level;
   

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
        health = 75;
        mana = 75;
        level = 01;
      
    }

    void FixedUpdate()
    {

        currentState.updateState();
        checkGround();
        Debug.Log(currentState);

    }

    void checkGround()
    {

        if (Physics.Raycast(transform.position, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z)))
            jumping = false;

    }


    void OnTriggerEnter( Collider other)
    {
        if (other.tag == "Death")
        {
            Debug.Log("You have fallen to your death");


        }
    }


}
