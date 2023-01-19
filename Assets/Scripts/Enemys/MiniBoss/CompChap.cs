using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompChap : MonoBehaviour
{
    public CanvasChap canvas;

    private void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<CanvasChap>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        canvas.SetChapitaOn();
        canvas.boss = 1;
    }
}
