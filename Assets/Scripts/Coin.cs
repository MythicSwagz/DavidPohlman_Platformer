using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //"Public" innebär att det är en variabel jag kan komma åt i alla scripts.
    //"Static" innebär att "score" i "Coin" kommer alltid vara samma. Då skriver man "Coin.score".
    //"Int" använder vi för att sätta ett värde som inte innehåller decimaler. 
    public static int score;

    public int amount = 1;

    //Float innebär att du kan använda upp till 7 decimaler.
    public float spinSpeed = 180;

    //OnTriggerEnter2D innebär att när man nuddar det objekt med detta script på, så ska det som står i funktionen hända.
    //Objektet måste även ha en collider, som passar objektet. Du måste även ha "Is Trigger" i tryckt.
    //Collider2D innebär att den räknar med collidern som träffar dig.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om min "Player" nuddar objektet så ska detta hända.
        if (collision.tag == "Player")
        {
            //Coin.score är att jag kallar på min "score" variabel i "Coin" scriptet.
            //+= betyder öka.
            //Coin.score += amount betyder att "score" ökar med så mycket "amount" är värd.
            Coin.score += amount;
            //Destroy betyder att något förstörs. 
            //gameObject beyder att det är det objektet som scriptet ligger på.
            //Destroy(gameObject) betyder att objektet som har detta script förstörs när "Player" nuddar den.
            Destroy(gameObject);
            
        }
    }
    private void Update()
    {
        //Denna kod gör så att myntet roterar med spinSpeed i y-axeln.
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);

        
    }
}
