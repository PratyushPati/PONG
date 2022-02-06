using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovAI : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D ball;
    public float speed;
    public float height;


    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   
    private void FixedUpdate()
    {
        if (ball.velocity.x > 0)
        {
            if (ball.position.y > transform.position.y)
            {
                rb.AddForce(Vector2.up * speed);
            }else if(ball.position.y < transform.position.y)
            {
                rb.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if (transform.position.y > 0)
            {
                rb.AddForce(Vector2.down * speed);
            }
            else if (transform.position.y < 0)
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
    }
}
