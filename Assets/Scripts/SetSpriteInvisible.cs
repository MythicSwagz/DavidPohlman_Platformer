using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Denna kod gör så att våran KillTrigger och InvinsibleWall blir osynlig.
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
