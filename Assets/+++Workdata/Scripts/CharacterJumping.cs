using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJumping : MonoBehaviour
{

    private Rigidbody2D rb;

    [SerializeField] private float jumpforce = 5f;
    [SerializeField] private Transform groundCheckPosition;
    [SerializeField] private float groundCheckRadius;
    [SerializeField] private LayerMask layerGround;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnJump()
    {
        if (Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, layerGround))
        {
            rb.velocity = new Vector2(0f, jumpforce);
        }
    }
    
}
