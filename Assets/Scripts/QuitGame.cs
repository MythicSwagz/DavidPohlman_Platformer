using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //När jag nuddar ett objekt med detta script så stängs spelet av.
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
