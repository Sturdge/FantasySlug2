using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class StatePatternPlayer : MonoBehaviour
{

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

    public static float health;
    public static float mana;
    public static float XP;
    public static int level;
    public Image manabar;
    public Image xpBar;
    float manabarFill;
    float healthbarFill;
    float xpBarFill;
    public GameObject winMenu;
    public string backToMenu;
    public GameObject Player;

    private void Awake()
    {

        idleState = new IdleState(this);
        moveState = new MoveState(this);
        attackState = new AttackState(this);
        rigid = GetComponent<Rigidbody>();
        jumping = false;

    }

    void Start()
    {

        currentState = idleState;
        health = 75;
        mana = 75;
        level = 01;
        XP = 1;
        winMenu.SetActive(false);

    }

    void Update()
    {
        xpBarFill = XP / 100;
        manabarFill = mana / 100;
        currentState.updateState();
        checkGround();

        manabar.fillAmount = manabarFill;
        xpBar.fillAmount = xpBarFill;

        if(LivesManager.lives == 0)
        {

            Application.LoadLevel(backToMenu);

        }
    }

    void checkGround()
    {

        if (Physics.Raycast(transform.position, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z)))
            jumping = false;

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Death")
        {  LivesManager.lives -= 1;
            if (LivesManager.lives == 0)
            {

                Application.LoadLevel(backToMenu);

            }
            else
            {

                  transform.position = new Vector3(3, 2, 0);   

            }

            Debug.Log("You have fallen to your death");               
           
            Debug.Log("Highscore is" + scoreManager.Highscore);
                            
                          


            
           
        }

        if (other.tag == "Win")
        {
            Time.timeScale = 0.0f;
            
            Debug.Log("You have beat the level");
            winMenu.SetActive(true);
          
        }
        else // otherwise
        {
            Time.timeScale = 1.0f; // unpause the game
            winMenu.SetActive(false); // get rid of the pause menu. 
        }
    }

    

    public void WinBackToMenuButton()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel(backToMenu);

    }

    public void ExitGame()
    {
        Application.Quit();


    }
}

    



