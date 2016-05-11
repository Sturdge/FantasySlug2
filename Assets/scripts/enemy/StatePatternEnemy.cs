using UnityEngine;
using System.Collections;

public class StatePatternEnemy : MonoBehaviour
{

    [SerializeField]
    private int hp;

    [HideInInspector]
    public IEnemyState currentState;

    [HideInInspector]
    public EnemyIdleState idleState;

    [HideInInspector]
    public EnemyAttackState attackState;

    [HideInInspector]
    public EnemyMoveState moveState;

    public GameObject rC;

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

        print(hp);

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Sword" && GameObject.FindGameObjectWithTag("Player").GetComponent<StatePatternPlayer>().currentState == GameObject.FindGameObjectWithTag("Player").GetComponent<StatePatternPlayer>().attackState)
        {

            if (hp > 0)
                hp -= 1;
            else
                Destroy(this.gameObject);
        }

       
        if (other.tag == "Fireball" && GameObject.FindGameObjectWithTag("Player").GetComponent<StatePatternPlayer>().currentState == GameObject.FindGameObjectWithTag("Player").GetComponent<StatePatternPlayer>().attackState)
        {

            if (hp > 0)
                hp -= 1;
            else
                Destroy(this.gameObject);

        }


    }
}
