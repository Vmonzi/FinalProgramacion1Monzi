using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAreaAttack : MonoBehaviour
{
    BossAnimator _bossMov;


    private void Start()
    {
        _bossMov = GetComponentInParent<BossAnimator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entre");
            _bossMov.anim.SetBool("Attack", false);
            _bossMov.anim.SetBool("AreaAttack", true);
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Sali");
        _bossMov.anim.SetBool("Attack", true);
        _bossMov.anim.SetBool("AreaAttack", false);
    }
}
