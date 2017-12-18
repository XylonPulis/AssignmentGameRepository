using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckWinner : MonoBehaviour {
    public Text finalScores;
    // Use this for initialization
    void Start () {
        if (GoalScoreP1.Player1Score > GoalScoreP2.Player2Score)
        {
            finalScores.text = "WINNER Player 1: "+ GoalScoreP1.Player1Score+ " & LOSER Player 2: "+ GoalScoreP2.Player2Score;

        }
        else
        {
            finalScores.text = "WINNER Player 2: " + GoalScoreP2.Player2Score + " & LOSER Player 1: " + GoalScoreP1.Player1Score;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
