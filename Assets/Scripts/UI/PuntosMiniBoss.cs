using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosMiniBoss : MonoBehaviour
{
    Puntos pts;

    private void Start()
    {
        pts = GetComponent<Puntos>();
        pts.puntosActuales = 9;
    }

}
