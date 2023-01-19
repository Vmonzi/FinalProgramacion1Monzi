using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PjAttack : MonoBehaviour
{
    public int DamagePj;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthEnemys enemysHealth = collision.GetComponent<HealthEnemys>();
        if (enemysHealth != null)
        {
            enemysHealth.attackPJ(DamagePj);
        }
    }
}
