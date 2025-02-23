﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScored : MonoBehaviour
{
    public Scoring updateScore;
    public PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "playerGoal")
        {
            updateScore.PlayerGoal();
            player.Reset();

        }
        else if (collision.gameObject.tag == "enemyGoal")
        {
            updateScore.EnemyGoal();
            player.Reset();
        }
    }
}
