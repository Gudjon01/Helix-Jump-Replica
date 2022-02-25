using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Controller : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float moveX;
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f,-(moveX * rotateSpeed * Time.deltaTime),0);
        }

    }
}
