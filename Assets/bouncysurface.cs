using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncysurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballmovement ballmovement = collision.gameObject.GetComponent<ballmovement>();

        if(ballmovement != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ballmovement.addforce(-normal * bounceStrength);
        }
    }
}
