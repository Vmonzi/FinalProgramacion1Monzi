using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinibossColliderAttack : MonoBehaviour
{
    [SerializeField] MinibossMovement _mini;

    private void Start()
    {
        _mini = GetComponentInParent<MinibossMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
            _mini.minibossAnim.SetBool("Ataque", true);
            _mini.minibossAnim.SetBool("Walking", false);
              if (_mini.rbPj.position.x < _mini.rb.position.x)
              {
              _mini.minibossAnim.SetBool("MovIzq", true);
              }
              else if (_mini.rbPj.position.x >= _mini.rb.position.x)
              {
            _mini.minibossAnim.SetBool("MovIzq", false);
              }
       
      

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _mini.minibossAnim.SetBool("Ataque", false);
        _mini.minibossAnim.SetBool("Walking", true);
    }
}
