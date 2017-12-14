using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POneMovement : MonoBehaviour {

    float velocity = 0.3f;
    
    void Start () {
		
	}
	
	void Update () {

        Vector3 movement = transform.position;

        if (Input.GetKey(KeyCode.W))
            movement.y += velocity;

        if (Input.GetKey(KeyCode.S))
            movement.y -= velocity;

        movement.y = Mathf.Clamp(movement.y, -4f, 4f);
        transform.position = movement;
    }
}
