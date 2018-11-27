using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    //Här gör jag en bool som kollar om jag är på marken eller inte.
    public bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Här kollar jag om jag nuddar tagen "Ground".
        if (collision.tag == "Ground")
        {
            //Om jag nuddar marken så är "isGrounded" true eller sant.
            isGrounded = true;
        }
            
    }
    //OnTriggerExit2D innebär att när man lämnar det objekt med detta script på, så ska det som står i funktionen hända.
    //Objektet måste även ha en collider, som passar objektet. Du måste även ha "Is Trigger" i tryckt.
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            //När jag lämnar "Ground" så är "isGrounded" false eller falskt.
            isGrounded = false;
        }
            
    }
}
