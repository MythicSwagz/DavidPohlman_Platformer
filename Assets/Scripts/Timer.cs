using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timeElapsed;
    public TextMeshProUGUI time;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        time.text = string.Format("Time Elapsed: {0:0.}", timeElapsed);
    }
}
