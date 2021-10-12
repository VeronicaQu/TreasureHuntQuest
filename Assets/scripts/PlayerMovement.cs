using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = .05f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input. GetButtonDown("Jump"))
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
}
