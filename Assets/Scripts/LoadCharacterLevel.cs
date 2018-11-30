using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCharacterLevel : MonoBehaviour
{
    public string sceneToLoad = "CharacterSelection";
    public static string currentScene;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(sceneToLoad);
            Coin.score = 0;
        }
        if (Input.GetKey(KeyCode.X))
        {
            SceneManager.LoadScene(currentScene);
        }
    }
}
