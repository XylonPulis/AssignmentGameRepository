using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTwoMovement : MonoBehaviour {


    float velocity = 0.3f;

    void Start()
    {

    }

    void Update()
    {

        Vector3 movement = transform.position;

        if (Input.GetKey(KeyCode.Mouse0))
            movement.y += velocity;

        if (Input.GetKey(KeyCode.Mouse1))
            movement.y -= velocity;

        movement.y = Mathf.Clamp(movement.y, -4f, 4f);
        transform.position = movement;
    }
}