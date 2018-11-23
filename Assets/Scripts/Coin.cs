using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int score;

    public int amount = 1;

    public float spinSpeed = 180;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Coin.score += amount;
            Destroy(gameObject);
            
        }
    }
    private void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);

        
    }
}
