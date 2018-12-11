using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timeElapsed;
    public TextMeshProUGUI time;


    // Update is called once per frame
    void Update()
    {
        //Denna rad av kod lägger på 1 varje sekund på min float "timeElapsed".
        timeElapsed += Time.deltaTime;
        //Här tar jag min time variabel och formaterar den till text format. Där det ska stå den texten som är i orange.
        //Det som står i måsvingarna säger att du bara kan ha heltal. Sedan läggs "timeElapsed" på det inom måsvingarna.
        time.text = string.Format("Time Elapsed: {0:0.}", timeElapsed);
    }
}
