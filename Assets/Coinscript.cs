﻿using UnityEngine;
using System.Collections;

public class Coinscript : MonoBehaviour {
    public int pointsGained = 1;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            scoreManager.score += pointsGained; // add the pointsGained to the score. 
            Destroy(gameObject);

        }


    }

}