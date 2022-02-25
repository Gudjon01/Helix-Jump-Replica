using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothness;
    
    void Start()
    {
        offset = transform.position - target.position;
    }


    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + target.position, smoothness);
        transform.position = newPos;  
    }
}
