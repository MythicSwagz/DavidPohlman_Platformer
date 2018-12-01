using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSelection : MonoBehaviour
{
    //Här döper jag min SpriteRenderer till character.
    public SpriteRenderer character;

    //Här döper jag min Sprite till characterSprite.
    public Sprite characterSprite;

    //Här döper jag en variabel till charcterNumber.
    public int characterNumber;

    //Här gör jag en static int som jag döper till selectedPlayer och att den ska vara = 0.
    public static int selectedPlayer = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //När något kolliderar med tagen "Player" ska detta hända.
        if (collision.tag == "Player")
        {
            //Här visar jag att min character.sprite är min variabel.
            character.sprite = characterSprite;
            //Här säger jag att min selectedPlayer är = min variabel för selectedNumber.
            selectedPlayer = characterNumber;
        }

    }
}
