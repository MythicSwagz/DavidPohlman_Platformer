using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool left = true;

    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "InvisibleWall")
        {
            left = !left;
        }
        
    }
    private void FixedUpdate()
    {

        if (left == true)
        {
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
