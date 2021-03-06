﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GoalScoreP1 : MonoBehaviour {

    public Text score;
    public static int Player1Score = 0;
    int currentscore = 0;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D hit)
    {
        GameObject fBall = GameObject.Find("Football");
        LevelManager lm = new LevelManager();
        fBall.transform.position = new Vector3(0f, 0f, -2f);

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            currentscore += 2;
            Player1Score += 2;
            score.text = currentscore.ToString();
            if (currentscore == 10)
            {               
                currentscore = 0;
                lm.LoadNewScene("Level_02");

            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            currentscore += 4;
            Player1Score += 4;
            score.text = currentscore.ToString();
            if (currentscore == 20)
            {
                currentscore = 0;
                lm.LoadNewScene("Level_03");

            }
                    }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            currentscore += 6;
            Player1Score += 6;
            score.text = currentscore.ToString();
            if (currentscore == 30)
            {
                currentscore = 0;
                lm.LoadNewScene("PA Scene");

            }
        }


    }
}
