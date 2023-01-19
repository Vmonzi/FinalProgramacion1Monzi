using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovProyectile : MonoBehaviour
{
    public float       movProyectileEn;
    public Rigidbody2D seed;
    public float       timeDestroying;

    private void Update()
    {
        seed.MovePosition(seed.position + (Vector2)transform.right * movProyectileEn * Time.deltaTime);

        Destroy(this.gameObject, timeDestroying);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D Collider)
    {
        Destroy(this.gameObject);
    }
}
