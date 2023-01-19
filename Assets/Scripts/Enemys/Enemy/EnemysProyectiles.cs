using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysProyectiles : MonoBehaviour
{
    public GameObject    proyectile;
    public EnemysPatrol  movimientoEn;
    void Start()
    {
        movimientoEn = GetComponent <EnemysPatrol>();
    }

    public void EnemyProyectile()
    {

            GameObject spawnedproyectile =  Instantiate(proyectile, transform.position, transform.rotation);
            if (movimientoEn.enemysAnimator.GetBool ("MovIzq") == true)
            {
                spawnedproyectile.transform.Rotate(0, 180, 0);
            }
            else if (movimientoEn.enemysAnimator.GetBool("MovIzq") == false)
            {
                spawnedproyectile.transform.Rotate(0, 0, 0);
            }

           
    }
}
