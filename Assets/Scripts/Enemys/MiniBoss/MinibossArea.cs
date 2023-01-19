using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinibossArea : MonoBehaviour
{
    MinibossMovement _mov;


    private void Start()
    {
        _mov = GetComponentInParent<MinibossMovement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            _mov.WakeUp();
    }
}
