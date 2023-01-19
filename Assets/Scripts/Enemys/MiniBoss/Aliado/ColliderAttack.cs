using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAttack : MonoBehaviour
{
    [SerializeField] MovementAliado _mini;


    private void Start()
    {
        _mini = GetComponentInParent<MovementAliado>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
             _mini.minibossAnim.SetBool("Ataque", true);
             _mini.minibossAnim.SetBool("Walking", false);
            if (_mini.objetivo.position.x < _mini.rb.position.x)
            {
            _mini.minibossAnim.SetBool("MovIzq", true);
            }
            else if (_mini.objetivo.position.x >= _mini.rb.position.x)
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
