using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysPatrol : MonoBehaviour
{
    public Transform    targetA; 
    public Transform    targetB;
    public Transform    targetActual;
    public float        movement = 40;
    public Animator     enemysAnimator;
    public Rigidbody2D  enemy;
    private HealthEnemys _health;
    public Gems         recolectables;
    public GameObject   objetivo;
    public void Start()
    {
        targetActual = targetA;
        _health = GetComponent<HealthEnemys>();
        recolectables = GetComponent<Gems>();

    }
    public void Update()
    {

        if (!enemysAnimator.GetBool("Attack") && !enemysAnimator.GetBool("Death"))
        {
            Enemysmovement();
        }
       
    }

    public void Enemysmovement ()
    {
        enemysAnimator.SetBool("Walking", true);
        transform.position = Vector3.MoveTowards(transform.position, targetActual.position, movement * Time.deltaTime);
        if (enemy.position == (Vector2)targetA.position)
        {   
            
            targetActual = targetB;
            enemysAnimator.SetBool ("MovIzq", true);
                        
        }
        else if (enemy.position == (Vector2)targetB.position)
        {
            targetActual = targetA;
            enemysAnimator.SetBool("MovIzq", false);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.isTrigger && collision.gameObject == objetivo)
        {
           if (collision.transform.position.x < enemy.position.x )
            {
                enemysAnimator.SetBool("MovIzq", true);
            }

           else if (collision.transform.position.x >= enemy.position.x)
            {
                enemysAnimator.SetBool("MovIzq", false);
                
            }

            
         Invoke("Ataque", 0.1f);

        }
        
    }

    void Ataque ()
    {
      enemysAnimator.SetBool("Attack", true);
      enemysAnimator.SetBool("Walking", false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enemysAnimator.SetBool("Attack", false);
        if (targetActual == targetB)
        {
            enemysAnimator.SetBool("MovIzq",  true);
        }
        else if (targetActual == targetA)
        {
            enemysAnimator.SetBool("MovIzq", false);
        }
    }

    public void Death()
    {
        Destroy(this.gameObject);    
    }
    public void Gems()
    {
        recolectables.Spawn();
    }

    public void Velocity()
    {
        movement -= 25;
    }


}
