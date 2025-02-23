using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    //RigidBody no Rigibody
    public Rigidbody2D rigidbody2d;
    
    //izquierda o derecha
    private float inputValue;
    
    //movespeed es la velocidad, es publica para poder modificarlo desde unity
    public float moveSpeed = 25;
    
    //eje X/Y
    private Vector2 direction;

    private Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        inputValue = Input.GetAxis("Horizontal");

        if (inputValue == 1){
          direction = Vector2.right;  
        } else if (inputValue == -1)
        {
            direction = Vector2.left;
        } else
        {
            direction = Vector2.zero;
        }
        
        rigidbody2d.AddForce(direction * moveSpeed * Time.deltaTime * 100);

    }
    
    public void ResetPlayer() {
        transform.position = startPosition;
        rigidbody2d.velocity = Vector2.zero;
    }
}
