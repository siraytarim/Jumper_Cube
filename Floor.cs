using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public float zýplamakuvveti;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {

            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 zýplamavelocity = rb.velocity;
                zýplamavelocity.y = zýplamakuvveti;
                rb.velocity = zýplamavelocity;
            }
        }
    }
}
