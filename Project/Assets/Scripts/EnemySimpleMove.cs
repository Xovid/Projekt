using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySimpleMove : MonoBehaviour
{
    public Transform playerPositon;
    public float enemyMoveSpeed;
    public float checkRadius;

    private Rigidbody2D rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   

    private void FixedUpdate()
    {
    }
}

