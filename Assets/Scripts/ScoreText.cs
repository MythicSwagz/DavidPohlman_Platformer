using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    //Private betyder att jag bara kan se den i detta script.
    //Jag döper en TextMeshProUGUI till text;
    private TextMeshProUGUI text;
    

    // Use this for initialization
    void Start()
    {
        //Här kollar jag upp vilken TextMeshProUGUI som jag menar. 
        //I detta fall tar jag den TextMeshProUGUI som scriptet ligger på.
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Denna kod säger att texten ska vara en text. Det blir en string.Format alltså något som skrivs.
        //Det som står i parantesen ska vara det som skrivs ut på skärmen. I detta fall Score: Antalet coins du har/4.
        //Coin.Score kollar hur mycket du har.
        text.text = string.Format("Score: {0:0}/4", Coin.score);
    }
}
