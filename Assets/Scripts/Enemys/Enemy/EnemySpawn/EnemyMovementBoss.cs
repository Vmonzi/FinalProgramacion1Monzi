using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBoss : MonoBehaviour
{
    private HealthEnemys _health;
    public GameObject objetivo;
    public Animator enemysAnimator;
    public Rigidbody2D rb;
    Movement _movPj;
    public float velocity = 30;
    public void Start()
    {
        _health = GetComponent<HealthEnemys>();
        objetivo = GameObject.Find("Pj");
        enemysAnimator = GetComponent<Animator>();
        _movPj = objetivo.GetComponent<Movement>();
    }

    public void Update()
    {

        if (!enemysAnimator.GetBool("Attack") && !enemysAnimator.GetBool("Death"))
        {
            Enemysmovement();
        }


    }
    public void Enemysmovement()
    {
        enemysAnimator.SetBool("Walking", true);
        rb.transform.position = Vector3.MoveTowards(rb.position, new Vector3(_movPj.myRigidBody.position.x, _movPj.myRigidBody.position.y, 0), velocity * Time.deltaTime);

        if (_movPj.myRigidBody.position.x < rb.position.x)
        {
            enemysAnimator.SetBool("MovIzq", true);
            
        }
        else if (_movPj.myRigidBody.position.x >= rb.position.x)
        {
           enemysAnimator.SetBool("MovIzq", false);
        
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.isTrigger && collision.gameObject == objetivo)
        {
            if (collision.transform.position.x < rb.position.x)
            {
                enemysAnimator.SetBool("MovIzq", true);
            }

            else if (collision.transform.position.x >= rb.position.x)
            {
                enemysAnimator.SetBool("MovIzq", false);

            }


            Invoke("Ataque", 0.1f);

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enemysAnimator.SetBool("Attack", false);
    }

    void Ataque()
    {
        enemysAnimator.SetBool("Attack", true);
        enemysAnimator.SetBool("Walking", false);
    } 

    public void Death()
    {
        Destroy(this.gameObject);
    }

    public void Velocity()
    {
        velocity -= 15;
    }
}
