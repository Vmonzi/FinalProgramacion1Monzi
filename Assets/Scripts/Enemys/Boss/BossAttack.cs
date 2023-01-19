using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public GameObject hit;

    private void Start()
    {
        hit.SetActive(false);
    }

    public void Attack()
    {
        hit.SetActive(true);
    }

    public void NoAttack()
    {
        hit.SetActive(false);
    }
}
