using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    public float movingspeed;
    private float horizontalmove;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontalmove = Input.GetAxis("Horizontal");    // tuþlarla hareket için
        rb.velocity =  new Vector2(horizontalmove*movingspeed*Time.deltaTime, rb.velocity.y);

        Vector2 newscale = transform.localScale;

        if(horizontalmove > 0)   //karakter sola gidiyosa
        {
            newscale.x = 0.6f;  // 0.6 karaktersin scale deðeriS
        }

        if (horizontalmove < 0) 
        {
            newscale.x = -0.6f;
        }
        transform.localScale = newscale;

    }
}
