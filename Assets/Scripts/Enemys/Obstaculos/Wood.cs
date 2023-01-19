using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    Puntos pts;
    [SerializeField] GameObject _wood1;
    [SerializeField] GameObject _wood2;
    [SerializeField] GameObject _wood3;

    private void Start()
    {
        pts = GameObject.Find("Canvas").GetComponent<Puntos>();
        _wood1.SetActive(true);
        _wood2.SetActive(true);
        _wood3.SetActive(true);
    }

    private void Update()
    {
        
        if (pts.puntosTotales == 10)
        {
            _wood1.SetActive(false);
            _wood2.SetActive(false);
            _wood3.SetActive(false);
        }
    }
}
