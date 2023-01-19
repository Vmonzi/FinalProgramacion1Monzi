using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public Text puntos;
    public int puntosTotales;
    public int puntosActuales;



    void Update()
    {
        puntosTotales =+ puntosActuales;
        puntos.text = "" + puntosTotales;
    }
}
