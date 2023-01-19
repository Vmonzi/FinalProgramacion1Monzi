using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BayaExp : MonoBehaviour
{
    ProyectileMovementPj _proyectile;
    public LayerMask Enemys;

    private void Start()
    { 
        _proyectile = GetComponent<ProyectileMovementPj>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collider2D[] enemys = Physics2D.OverlapCircleAll(_proyectile.transform.position, 60f);
        foreach (Collider2D obj in enemys)
        {
            if(obj.gameObject.CompareTag("MiniBoss") || obj.gameObject.CompareTag("EnemyComun") || obj.gameObject.CompareTag("EnemyVariant"))
            {
                obj.gameObject.GetComponent<HealthEnemys>().Muerte();
                Debug.Log("pium pium");
            }
                
        }
    }
}
