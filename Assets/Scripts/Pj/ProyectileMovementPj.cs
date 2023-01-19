using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileMovementPj : MonoBehaviour
{
    public float movementProyectile;
    public Rigidbody2D myRigidBody;
    public float timeDestroying;
    public GameObject explos;

    private void FixedUpdate()
    {
        myRigidBody.MovePosition(myRigidBody.position + (Vector2)transform.right * movementProyectile * Time.deltaTime);

        Destroy(this.gameObject, timeDestroying);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destruir();
    }
    public void Destruir()
    {
        Instantiate(explos, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    } 

}
