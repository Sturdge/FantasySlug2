using UnityEngine;
using System.Collections;

public class fireBallscript : MonoBehaviour
{

    public float speed = 1f; // Create a float to hold the speed of the bullet. 
    public int pointsGained = 1; // Create a int to hold the amount of points gained by destroying a target. 




    // Use this for initialization
    void Start()


    {

        Destroy(gameObject, 10f); // Destroy the bullet after ten seconds. 



    }


    // Update is called once per frame
    void Update()


    {
        transform.Translate(0, 0, speed); // Move the bullet. 






    }


  
    




}
