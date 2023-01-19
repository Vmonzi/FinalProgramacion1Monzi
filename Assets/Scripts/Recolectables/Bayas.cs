using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bayas : MonoBehaviour
{
    [SerializeField] GameObject _pj;
    public PjHealth              life;
    BayasUI                     _bayas;
    Movement                    _movPj;
    public GameObject            particle;
    public AudioSource           myAudio;
    public AudioClip             recolec;
     
    private void Start()
    {
        life = _pj.GetComponent<PjHealth>();
        _bayas = GameObject.Find("Canvas").GetComponent<BayasUI>();
        _movPj = _pj.GetComponent<Movement>();
        myAudio.clip = recolec;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == _pj)
        {
            
            if (this.gameObject.CompareTag("Rojo") && life.actualHealth > 0)
            {
               
                    Instantiate(particle, transform.position, Quaternion.identity);
                    myAudio.Play();
                    life.actualHealth -= 15;
                    Destroy(this.gameObject, 0.5f);
           
            }
          
            if (this.gameObject.CompareTag("Rosa") && _movPj.baya2 == 0)      //Baya Rosa
            {
                Instantiate(particle, transform.position, Quaternion.identity);
                myAudio.Play();
                Destroy(this.gameObject, 0.5f);
                _movPj.baya2 = 1;
                _bayas.Baya2();
               
            }
            
            if (this.gameObject.CompareTag("Violeta") && _movPj.baya1 == 0)   //Baya Violeta
            {
                Instantiate(particle, transform.position, Quaternion.identity);
                myAudio.Play();
                Destroy(this.gameObject, 0.5f);
                _movPj.baya1 = 1;
                _bayas.Baya1();
            }
        }
    }

}
