using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class double_jump : MonoBehaviour
{
    private Rigidbody2D rb;
    private int extraJump;
    public int extraJumpValue;
    public float Jumpforce;
    private bool isGrounded;
    public Transform point;
    public float CheckRadius;
    public LayerMask GroundLayer;
   
    void Start()
    {
        extraJump = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();
       
    }
     private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(point.position, CheckRadius, GroundLayer);
        if (isGrounded == true)
        {
            extraJump = extraJumpValue;
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity = Vector2.up * Jumpforce;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJump > 0)
        {
            rb.velocity = Vector2.up * Jumpforce;
            extraJump--;
        }
    }
}
