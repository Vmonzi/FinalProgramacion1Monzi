using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float        movementPJ;
    public Rigidbody2D  myRigidBody;
    public Animator     myAnimator;
    public Vector2      inputVector;
    public bool         ataque;
    Vector2             posicion;
    public int          baya1;
    public int          baya2;
    BayasUI            _bayas;


    private void Start()
    {
        _bayas = GameObject.Find("Canvas").GetComponent<BayasUI>();
    }
    private void FixedUpdate()
    {
        Movimiento    ();
        Attack        ();

        if (Input.GetKeyDown("1") && baya1 == 1)
        {
            _bayas.Baya1Select();
        }
        if (Input.GetKeyDown("2") && baya2 == 1)
        {
            _bayas.Baya2Select();
        }
        if (baya1 == 0)
        {
            _bayas.Baya1Off();
        }
        if(baya2 == 0)
        {
            _bayas.Baya2Off();
        }

        if(baya1 <= 0)
        {
            baya1 = 0;
        }
        if (baya2 <= 0)
        {
            baya2 = 0;
        }
      
    }

    private void Movimiento ()
    {
       
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
        myAnimator.SetFloat("HInput", inputVector.x);
        

        if ( ataque == false && (inputVector.x != 0f || inputVector.y != 0f) )
        {
            myRigidBody.MovePosition(myRigidBody.position + inputVector * movementPJ * Time.deltaTime);
            myAnimator.SetBool("Walking", true);

        }

        else
        {
            myAnimator.SetBool("Walking", false);
        }
    }

    private void Attack()
    {
            if (Input.GetButtonDown("Fire2") && inputVector.x == 0 && inputVector.y == 0 )
            {
            ataque = true;
            myAnimator.SetTrigger("FullAttack");
            
            }

          
            if (Input.GetButtonDown("Fire1"))
            {
            
            myAnimator.SetTrigger("Attack");

            }
    }

    private void StopAttack ()
    {
        ataque = false;
    }

   
}
