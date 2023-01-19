using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectiles : MonoBehaviour
{
    public GameObject     proyectile;
    public GameObject     bayaVioleta;
    public GameObject     bayaRosa;
    public SpriteRenderer mov;
    BayasUI              _bayas;
    Movement             _movpj;
    public AudioSource    myAudio;
    public AudioClip      proyectileSound;
    private void Start()
    {
        _bayas = GameObject.Find("Canvas").GetComponent<BayasUI>();
        _movpj = GetComponent<Movement>();
        
    }


    public void Proyectile1 ()
    {
        myAudio.clip = proyectileSound;
        myAudio.Play();
            GameObject spawnedprojectile = Instantiate(proyectile, transform.position, Quaternion.identity);
            if (mov.flipX == true)
            {
                spawnedprojectile.transform.Rotate (0, 180, 0);
            }
            else if (mov.flipX == false)
            {
                spawnedprojectile.transform.Rotate(0, 0, 0);
            }
    }

    public void Proyectile2 ()
    {
        myAudio.clip = proyectileSound;
        if (_bayas.baya1Select.isActiveAndEnabled == true)
        {
            _bayas.Baya1Off();
            _movpj.baya1 = 0;
            myAudio.Play();
            GameObject spawnedprojectile = Instantiate(bayaVioleta, transform.position, transform.rotation);
            if      (mov.flipX == true)
            {
            spawnedprojectile.transform.Rotate(0, 180, 0);
            }
            else if (mov.flipX == false)
            {
            spawnedprojectile.transform.Rotate(0, 0, 0);
            }
        }

        if (_bayas.baya2Select.isActiveAndEnabled == true)
        {
            myAudio.Play();
            _movpj.baya2 = 0;
            _bayas.Baya2Off();
            GameObject spawnedprojectile = Instantiate(bayaRosa, transform.position, transform.rotation);
            if (mov.flipX == true)
            {
                spawnedprojectile.transform.Rotate(0, 180, 0);
            }
            else if (mov.flipX == false)
            {
                spawnedprojectile.transform.Rotate(0, 0, 0);
            }
        }
    }
      
      
}
