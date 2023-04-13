using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float groundLength;

    void Start()
    {
        
    }

    void Update()
    {
        MoveFloor();
    }

    private void MoveFloor()
    {
        transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        
        if(transform.position.x >= groundLength)
        {
            transform.position = new Vector3(transform.position.x - groundLength, transform.position.y, transform.position.z);
        }
    }
}
