using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud : MonoBehaviour
{
    [SerializeField] Movement _movPj;
    [SerializeField] GameObject _pj;


    private void Start()
    {
        _movPj = _pj.GetComponent<Movement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == _pj && !collision.isTrigger)
        {
            _movPj.movementPJ = 35;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _movPj.movementPJ = 55;
    }

}
