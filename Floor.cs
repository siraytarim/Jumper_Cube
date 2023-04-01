using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public float zıplamakuvveti;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {

            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 zıplamavelocity = rb.velocity;
                zıplamavelocity.y = zıplamakuvveti;
                rb.velocity = zıplamavelocity;
            }
        }
    }
}
