using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnAttack : MonoBehaviour
{
    public int EnemysDamage;
    [SerializeField] GameObject pj;
    [SerializeField] GameObject mini;



    private void OnTriggerEnter2D(Collider2D collision)
    {
          PjHealth Health = collision.GetComponent<PjHealth>();
       
           if (Health != null)
           {
             Health.attackEnemys(EnemysDamage);
           }
        
    }

}
