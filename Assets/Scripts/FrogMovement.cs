using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    private Rigidbody2D rbody;
    public float jumpSpeed = 5f;
    public GroundChecker groundCheck;
    public Sprite nonGrounded;
    public Sprite grounded;
    private SpriteRenderer frog;
    public float timeElapsed;
    public float moveSpeed = 3f;
    public bool left = true;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        frog = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Här ett det som gör timern
        timeElapsed += Time.deltaTime;
        //Om grodan är på marken och timeElapsed är mindre än 2 så ska detta hända.
        if (groundCheck.isGrounded > 0 && timeElapsed > 2)
        {
            //Detta är det som behövs för att grodan ska kunna hoppa.
            rbody.velocity = new Vector2(
                  rbody.velocity.x,
                  jumpSpeed);
            //Grodans sprite byts till nonGrounded;
            timeElapsed = 0;

            frog.sprite = nonGrounded;
            //Timern sätts till 0
        }
        //Annars om jag är på marken så är det större än 0.
        else if (groundCheck.isGrounded > 0)
        {
            //Grodans sprite byts till grounded
            frog.sprite = grounded;
        }

        if (left == false)
        {

            rbody.velocity = new Vector2(
            moveSpeed,
            rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {

            rbody.velocity = new Vector2(
            -moveSpeed,
            rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }




    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "InvisibleWall")
        {
            left = !left;
        }

    }
}
