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

    // Start SID: 1311554
    public static float health; // Variable to hold the players health.
    public static float startingHealth;// Holds the maximum health the player can have. 
    public static float startingMana; // holds the starting health the player has. 
    public static float mana; // Variable to hold the player mana.
    public static float XP; // Varible to hold the players XP.
    public static int level; // Varible to hold the players level. 
    public Image manabar; // Used to hold the manabar image used in the GUI.
    public Image xpBar; // Used to hold the xp bar image used in the GUI.
    public Image hpBar; // Used to hole the health bar image used in the GUI.
    float manabarFill; // used to hold the fill level of the manabar.
    float healthbarFill; // Used to hold the fill level of the health bar. 
    float xpBarFill; // used to hold the fill level of the XP bar
    public GameObject winMenu; // Hold the menu that appears when the player wins the game.
    public string backToMenu; // Holds the string of the main menu scene which will load when a back to menu button is pressed.
    public string deathscreen; // Holds the string of the death screen scene which will load when the player dies. 
    public GameObject Player; // Used to hold the player gameobject. 
    // End SID: 1311554 

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
        // Start SID: 1311554
        health = 75; // Health of the player is set at 75
        mana = 75; // Mana of the player is set at 75
        startingHealth = health;
        level = 01; // Level of the player is set at 1;
        XP = 1; // The player has 1 XP.
        winMenu.SetActive(false); // The menu that appears when the player beats the level is turned off. 
        // End SID: 1311554

    }

    void Update()
    {
        checkGround();
        currentState.updateState();
        // Start SID: 1311554
        xpBarFill = XP / 100; // The XPbarfill is equal to the value held in XP / 100
        manabarFill = mana / 100; // The manabarfill value is equal to the value held in XP / 100
        healthbarFill = health / 100; // The healthbarfill value is equal to the value held in health / 100.
        manabar.fillAmount = manabarFill; // Uses the manabarFill value to change how much mana the player has.
        xpBar.fillAmount = xpBarFill; // Uses the xpBarFill  value to change how much XP the player has.
        hpBar.fillAmount = healthbarFill; // uses the healthbarfill value to change the health of the player on the GUI. 

        if (LivesManager.lives == 0) // If the player has run out of lives. 
        {

            Application.LoadLevel(deathscreen); // Load the main menu.

        }

        if(health < 1) // If the players health is lower than 1.
        {
            transform.position = new Vector3(3, 2, 0); // respawn the player
            LivesManager.lives -= 1; // take away a life.
            health = startingHealth; // health is starting health.
            mana = startingMana; // mana is reset. 


        }

        if(XP >= 99) // if the player has reached the end of the xp bar.
        {

            level += 1; // The player has leveled up.
            XP = 1; // reset the XP bar. 

        }
        // End SID: 1311554 
    }

    void checkGround()
    {

        if (Physics.Raycast(transform.position, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z)))
            jumping = false;

    }

    void noHealth()
    {

      

    }

    void OnTriggerEnter(Collider other)
    {

        //Start SID: 1311554
        if (other.tag == "Death") // If the player hits the fall trigger.
        {  LivesManager.lives -= 1; // Take 1 life away from the player. 
            if (LivesManager.lives == 0) // If the player runs out of lives.
            {

                Application.LoadLevel(deathscreen); // load the death screen.

            }
            else //Otherwise
            {

                  transform.position = new Vector3(3, 2, 0);   // Place the player back at the inital spawn. 

            }

            Debug.Log("You have fallen to your death");               
           
                                                                                
        }

        if (other.tag == "Win") // If the player hits the win trigger.
        {
            Time.timeScale = 0.0f; // pause the game
            
            Debug.Log("You have beat the level");
            winMenu.SetActive(true); // Make the win menu appear
          
        }  
        // End SID: 1311554      
    }

    
    // Start SID: 1311554
    public void WinBackToMenuButton() // Back to menu button function on the win menu.
    {
        Time.timeScale = 1.0f; // Unpause the game
        Application.LoadLevel(backToMenu); // Load the main menu.

    }

    public void ExitGame() // Exit button function on the win menu. 
    {
        Application.Quit(); // Quit the application.


    }
    // End SID: 1311554
}

    



