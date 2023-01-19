using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BayaRealent : MonoBehaviour
{
    [SerializeField] GameObject _miniboss;
    [SerializeField] GameObject _enemy;
    [SerializeField] GameObject _enemySpawn;
    MinibossMovement            _miniMov;
    EnemyMovementBoss           _enemySpawnMov;
    EnemysPatrol                _enemyPatrolMov;
    ProyectileMovementPj        _proyectile;

    private void Start()
    {
        _miniMov        = _miniboss.GetComponent<MinibossMovement>();
        _enemySpawnMov  = _enemySpawn.GetComponent<EnemyMovementBoss>();
        _enemyPatrolMov = _enemy.GetComponent<EnemysPatrol>();
        _proyectile     = GetComponent<ProyectileMovementPj>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collider2D[] enemys = Physics2D.OverlapCircleAll(_proyectile.transform.position, 30f);
        foreach (Collider2D obj in enemys)
        {
            if (obj.gameObject.CompareTag ("MiniBoss"))
            {
                obj.gameObject.GetComponent<MinibossMovement>().Velocity();
                Debug.Log("Realent Miniboss");
            }

            if (obj.gameObject.CompareTag("EnemyComun"))
            {
                obj.gameObject.GetComponent<EnemysPatrol>().Velocity();
                Debug.Log("Realent enemy");
            }

            if (obj.gameObject.CompareTag("EnemyVariant"))
            {
                obj.gameObject.GetComponent<EnemyMovementBoss>().Velocity();
                Debug.Log("Realent variant");
            }
        }
    }

}

