using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppChapa : MonoBehaviour
{
    public GameObject chapa;
    public MinibossMovement mini;
    public GameObject gema;

    private void Start()
    {
        mini = GetComponent<MinibossMovement>();

    }
    public void Spawn()
    {
        GameObject chap = Instantiate(chapa, mini.chap.position, Quaternion.identity);
        GameObject gem = Instantiate(gema, mini.rb.position, Quaternion.identity);
    }
}
