using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinibossAttack : MonoBehaviour
{
    [SerializeField] GameObject _hit;

    private void Start()
    {
        _hit.SetActive(false);
    }
    public void MiniAttack()
    {
        _hit.SetActive(true);
    }

    public void MiniAttackStop()
    {
    
        _hit.SetActive(false);
    }

}
