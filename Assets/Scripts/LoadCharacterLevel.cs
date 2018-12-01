using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCharacterLevel : MonoBehaviour
{
    //Här gör ajg en variabel som jag döper till sceneToLoad, som laddar scenen CharacterSelection.
    public string sceneToLoad = "CharacterSelection";
    //Här gör jag en static variabel som jag döper till currentScene.
    public static string currentScene;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //När man klickar på C på tangentbordet så ska de som står innuti hända.
        if (Input.GetKey(KeyCode.C))
        {
            //Här hämtar jag den aktiva scenen.
            currentScene = SceneManager.GetActiveScene().name;
            //Här laddar jag scenen som står i sceneToLoad.
            SceneManager.LoadScene(sceneToLoad);
            //Jag sätter även mitt coin score till 0.
            Coin.score = 0;
        }
        //När man klickar på X på tangentbordet så ska de som står innuti hända.
        if (Input.GetKey(KeyCode.X))
        {
            //Här byter jag till den scenen jag tidigare var på.
            SceneManager.LoadScene(currentScene);
        }
    }
}
