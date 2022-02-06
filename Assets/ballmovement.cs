using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        resetpoision();
    }

    public void AddStrarforcr()
    {
        float x = Random.value < 0.5 ? -1.0f : 1.0f;
        float y = Random.value < 0.5 ? Random.Range(-1.0f,-0.5f) : Random.Range(0.5f,1.0f);
        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * speed );
    }
    public void addforce(Vector2 force)
    {
        rb.AddForce(force);
    }
    public void resetpoision()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;
        AddStrarforcr();
    }
}
