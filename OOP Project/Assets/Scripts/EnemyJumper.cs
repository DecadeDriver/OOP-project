using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumper : Enemy
{
    protected override void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        jumpForce = 15;
        enemyRb.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
    }

    protected override void MovingForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed );
    }
    
}
