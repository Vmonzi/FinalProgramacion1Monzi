using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{
    public GameObject       gemas;
    public EnemysPatrol     enemy;

    private void Start()
    {
         enemy = GetComponent<EnemysPatrol>();
        
    }
    public void Spawn()
    {
        GameObject gems = Instantiate(gemas, enemy.enemy.position, Quaternion.identity);
       
    }

}