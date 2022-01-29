using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectai : MonoBehaviour
{

    public float projectialSpeed;
    public GameObject impactEffect;


    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.right * projectialSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        
    }
}
