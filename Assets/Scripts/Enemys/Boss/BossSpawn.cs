using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    [SerializeField] float radio = 4, time = 2f;

    public GameObject enemy;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        Vector2 spawnPos = GameObject.Find("Pj").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * radio;
        Instantiate(enemy, spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnEnemy());

        
    }
}
