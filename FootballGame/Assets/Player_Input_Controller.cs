using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {
    //Script handles controls from both players.
    //Player 1 uses W/S as controls.
    //Player 2 uses Up Arrow/Down Arrow as controls.

    public GameObject PlayerOne;
    public GameObject PlayerTwo;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //default player speed
        PlayerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

        if (Input.GetKey(KeyCode.W))
        {
            PlayerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 5f);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            PlayerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -5f);
        }



        PlayerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

        if (Input.GetKey(KeyCode.Mouse0))
        {
            PlayerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 5f);
        }

        else if (Input.GetKey(KeyCode.Mouse1))
        {
            PlayerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -5f);
        }



    }
}
