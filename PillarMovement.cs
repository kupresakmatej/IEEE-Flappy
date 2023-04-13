using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMovement : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        MovePillars();

        DestroyPillar();
    }

    private void MovePillars()
    {
        transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
    }

    private void DestroyPillar()
    {
        if(transform.position.x >= 5.5f)
        {
            Destroy(gameObject);
        }
    }
}