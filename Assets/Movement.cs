using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;  
    private Rigidbody2D rb;      

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        
        Vector2 direction = new Vector2(horizontalInput, verticalInput).normalized;

        // Update the velocity of the Rigidbody2D
        rb.velocity = direction * speed;
    }
}
