using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class temporizador : MonoBehaviour
{
    public TMP_Text countertext;
    float sec;
    float min;

    // Update is called once per frame
    void Update()
    {
        min = (int)(Time.time / 60F);
        sec = (int)(Time.time % 60F);
        countertext.text = min.ToString("00") + ":" + sec.ToString("00");
    }

    void acelerador()
    {
        if (sec == %5)
        {

        }
    }
}
