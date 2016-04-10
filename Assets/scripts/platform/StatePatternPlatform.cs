using UnityEngine;
using System.Collections;

public class StatePatternPlatform : MonoBehaviour {

    [HideInInspector]
    public IPlatformState currentState;

    [HideInInspector]
    public PlatformIdleState idleState;

    [HideInInspector]
    public PlatformMoveState moveState;

	[SerializeField]
	public int platformType;

	[HideInInspector]
	public Rigidbody rigid;

	[HideInInspector]
	public Vector3 originalPos;

	[HideInInspector]
	public Vector3 targetPos;

	[HideInInspector]
	public Vector3 currentPos;

    private void Awake()
    {

        idleState = new PlatformIdleState(this);
        moveState = new PlatformMoveState(this);
		rigid = GetComponent<Rigidbody> ();
		originalPos = this.transform.position;
		targetPos = new Vector3 ( originalPos.x + 5, originalPos.y, originalPos.z );
		currentPos = originalPos;

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
