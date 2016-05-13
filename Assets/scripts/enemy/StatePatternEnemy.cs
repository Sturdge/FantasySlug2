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
        if (other.tag == "Sword" )
        {
            if (hp > 0)
            {
                hp -= 1;
            }
            if (hp == 0)
            {
                Destroy(this.gameObject);
                StatePatternPlayer.XP += 10;
            }
        }


        if (other.tag == "Fireball")
        {

            if (hp > 0)
                hp -= 1;
           
        }
        if (hp == 0)
        {
            Destroy(this.gameObject);
            StatePatternPlayer.XP += 10;
        }



      

        }


    }

