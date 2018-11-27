using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //Här sätter jag variabeln "speed" till 2.  
    public float speed = 2f;
    //Detta är en bool som säger ja eller nej. Jag sätter variabeln left till true.
    public bool left = true;

    //Här döper jag fiendens Rigidbody2D till rbody.
    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        //Här kollar jag upp vilken Rigidbody2D som jag menar. 
        //I detta fall tar jag den Rigidbody2D som scriptet ligger på.
        rbody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Denna kod kollar om du nuddar "InvisibleWall".
        if (collision.tag == "InvisibleWall")
        {
            //Denna kod kollar om fienden kan gå vänster eller höger när du kommer i kontakt med "InvisibleWall". 
            //Om du nuddar den från vänster sidan så går han höger. Samma sak gäller fast för motsatta sidan.
            left = !left;
        }
        
    }
    private void FixedUpdate()
    {
        //När fienden rör sig åt vänster gäller denna kod.
        if (left == true)
        {
            //Denna rad med kod bestämmer hur snabbt fienden ska röra sig. Notera minus tecknet innan (Vector2) som gör att 
            //det blir motsatsen till transforn.right vilket blir att den rör sig åt vänster.
            rbody.velocity = -(Vector2)transform.right * speed;
            //Denna kod gör så att spriten roteras åt det håll den rör sig. Alltså att nosen alltid är framåt.
            transform.localScale = new Vector3(1, 1, 1);
        }
        //När fienden rör sig år höger gäller denna kod.
        else
        {
            //Denna rad med kod bestämmer hur snabbt fienden ska röra sig.
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
