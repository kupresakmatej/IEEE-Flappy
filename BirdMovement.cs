using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float flapHeight;
    [SerializeField] private Animator birdAnimator;

    private bool isGrounded;

    private Rigidbody rb;

    void Start()
    {
        isGrounded = false;

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {       
        if(!isGrounded)
        {
            if(Input.GetMouseButtonDown(0))
            {
                MoveUpward();
                PlayAnimation();
            }
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    private void MoveUpward()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(new Vector3(0f, flapHeight, 0f));
    }

    private void PlayAnimation()
    {
        birdAnimator.SetTrigger("Fly");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        else if(collision.gameObject.tag == "Pillar")
        {
            SceneManager.LoadScene(0);
        }
    }
}
