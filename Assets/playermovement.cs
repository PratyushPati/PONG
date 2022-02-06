using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float height;


    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        Vector2 newpos = rb.position + Vector2.up * y;
        newpos.y = Mathf.Clamp(newpos.y, -height, height);

        rb.MovePosition(newpos);
    }
}
