using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSelection : MonoBehaviour
{
    public SpriteRenderer character;
    public Sprite characterSprite;

    public int characterNumber;

    public static int selectedPlayer = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            character.sprite = characterSprite;
            selectedPlayer = characterNumber;
        }

    }
}
