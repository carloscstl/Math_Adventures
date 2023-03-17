 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speedMovement = 0.8f;
    private Rigidbody2D rb;
    private Vector2 direction;
    public Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal",direction.x);
        animator.SetFloat("Vertical",direction.y);
        animator.SetFloat("Speed", direction.sqrMagnitude);
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speedMovement * Time.fixedDeltaTime);
    }
    
}
