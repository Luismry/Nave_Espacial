using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class temporizador : MonoBehaviour
{
    public TMP_Text countertext;
    public float sec;
    float min;
    public meteoritosAlvaro gm;

    // Update is called once per frame
    void Update()
    {
        min = (int)(Time.timeSinceLevelLoad / 60F);
        sec = (int)(Time.timeSinceLevelLoad % 60F);
        countertext.text = min.ToString("00") + ":" + sec.ToString("00");
    }

    
}
