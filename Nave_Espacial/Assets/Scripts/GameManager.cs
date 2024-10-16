using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Nave;

    public void ResetPos()
    {
        Nave.GetComponent<Movimiento>().Reset();


    }

}
