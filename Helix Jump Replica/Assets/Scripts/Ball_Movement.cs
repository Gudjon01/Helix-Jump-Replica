using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpforce;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float fallSpeed;


    private void FixedUpdate()
    {
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity = rb.velocity * fallSpeed;
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * jumpforce);
    }
}
