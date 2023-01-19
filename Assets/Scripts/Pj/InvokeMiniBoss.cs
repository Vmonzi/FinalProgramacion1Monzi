using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeMiniBoss : MonoBehaviour
{
    CanvasChap _chapa;
    public GameObject aliado;
    public GameObject particle;
    public GameObject canvas;

    private void Start()
    { 
        _chapa = canvas.GetComponent<CanvasChap>();
    }

    private void Update()
    {
        if (_chapa.boss == 1)
        {
            InvokeMini();
            
        }
    }


    public void InvokeMini()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Instantiate(aliado, transform.position, Quaternion.identity);
            _chapa.boss = 0;
        }
    }
}
