using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    public float speed = .05f;

    [SerializeField] private LayerMask jumpableGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input. GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector3(0, 14f, 0);
        }
         if (Input.GetKey(KeyCode.LeftArrow)){

            transform.Translate(Vector2.right * -1 * speed);
        }
        
        if (Input.GetKey(KeyCode.RightArrow)){

            transform.Translate(Vector2.right * speed);
             
    }
}
private bool IsGrounded()
{
  return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
} 
}
