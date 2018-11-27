using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int minimumScoreNeeded = 4;
    //"String" är något vi använder för att skriva in text istället för siffror.
    //public string sceneToLoad = "LevelOne" betyder att när jag nuddar ett objekt med detta script på
    //så laddar vi in scenen "Level One". Vi kan även byta ut "LevelOne" mot en anna "Scene" i Unity.
    public string sceneToLoad = "LevelOne";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //När min "Player" nuddar objektet med detta script på och jag har 4 i "score" alltså alla coins så fungerar 
        //detta script.
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            //När jag har laddat in banan så sätts Coin.score till 0.
            Coin.score = 0;
            //Den laddar även den "Scene" jag har lagt till som variabel.
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
