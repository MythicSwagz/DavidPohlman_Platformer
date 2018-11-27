using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Här bestämmer jag hastigheten för "Player".
    public float moveSpeed = 6f;
    //Här bestämmer jag hopp hastigheten för "Player".
    public float jumpSpeed = 12f;

    //Här döper jag min "GroundChecker" till "groundCheck".
    public GroundChecker groundCheck;

    //Här döper jag en RigidBody2D till rbody.
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Detta stycke utav kod gör så att "Player" rör sig åt höger eller väsnter med någon av de horisontella tangenterna 
        //eller på kontrollen.
        rbody.velocity = new Vector2(
            Input.GetAxis("Horizontal") * moveSpeed,
            rbody.velocity.y);
        // Denna kolla om knappen för "Jump" är nedtryckt.
        if (Input.GetButtonDown("Jump"))
        {
            //Detta stycke av kod kollar om "Player" är på marken. Om "Player" är på marken så kan den hoppa.
            if (groundCheck.isGrounded == true)
            {
                //Dessa rader utav kod bestämmer hur snabbt jag hoppar.
                rbody.velocity = new Vector2(
                  rbody.velocity.x,
                  jumpSpeed);
            }

        }






    }
}
