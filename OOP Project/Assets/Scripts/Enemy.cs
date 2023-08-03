using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected float speed;
    public float jumpForce;
    protected Rigidbody enemyRb;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
       MovingForward();
    }
    
    protected virtual void MovingForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
