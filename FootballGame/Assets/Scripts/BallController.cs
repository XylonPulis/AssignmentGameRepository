using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    Rigidbody2D rb;
  

    // Use this for initialization
    void Start () {


        //Ball chooses direction to fly to
        rb = GetComponent<Rigidbody2D>();

        //Random x-axis direction
        int xDirection = Random.Range(0, 2);

        //Random y-axis direction
        int yDirection = Random.Range(0, 2);

        Vector2 launchDirection = new Vector2();

        if(xDirection== 0)
        {
            launchDirection.x = -8f;
        }

        if (xDirection == 1)
        {
            launchDirection.x = 8f;
        }

        if (yDirection == 0)
        {
            launchDirection.y = -8f;
        }

        if (yDirection == 2)
        {
            launchDirection.y = 0f;
        }

        rb.velocity = launchDirection;
	}

    

    // Update is called once per frame
    void Update () {	
	}
        
    }
