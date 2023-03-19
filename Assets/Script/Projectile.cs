using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int bulletSpeed;
    Rigidbody2D rb;
    //public GameObject impactEffect;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;
    }

    // Update is called once per frame

    //Game effect ::
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //Instantiate(impactEffect, transform.position, Quaternion.identity);
        if(collision.CompareTag("KnightFire"))
        {
            Destroy(gameObject); 
        }
        if(collision.CompareTag("KnightWater"))
        {
            Destroy(gameObject); 
        }
        if(collision.CompareTag("KnightWood"))
        {
            Destroy(gameObject); 
        }
    }
}
