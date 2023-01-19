using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompGems : MonoBehaviour
{
    public Puntos     puntos;
    public GameObject particle;

    private void Start()
    {
        puntos = GameObject.Find("Canvas").GetComponent<Puntos>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {  
        Destroy(this.gameObject);
        Instantiate(particle, transform.position, Quaternion.identity);
        puntos.puntosActuales += 1;
    }
}
