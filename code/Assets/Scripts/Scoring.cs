using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public int scorePlayer = 0;
    public int scoreEnemy = 0;
    public Text displayScoreP;
    public Text displayScoreE;

    // Start is called before the first frame update
    void Start()
    {
        displayScoreP.text = "Red Score: " + scorePlayer.ToString();
        displayScoreE.text = "Blue Score: " + scoreEnemy.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerGoal()
    {
        scorePlayer++;
        displayScoreP.text = "Red Score:  " + scorePlayer.ToString();
    }

    public void EnemyGoal()
    {
        scoreEnemy++;
        displayScoreE.text = "Blue Score: " + scoreEnemy.ToString();
    }
}
