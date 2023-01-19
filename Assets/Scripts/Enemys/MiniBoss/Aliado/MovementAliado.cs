using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAliado : MonoBehaviour
{
    public Animator minibossAnim;
    public float velocity;
    public Rigidbody2D rb;
    public Rigidbody2D objetivo;
    public GameObject boss;
    public GameObject particles;
    void Start()
    {
        minibossAnim = GetComponent<Animator>();
        minibossAnim.SetBool("Aliado", true);
    }

    void Update()
    {
        if ( minibossAnim.GetBool("Ataque") == false)
        {
            MovMini();
        }
    }

    public void MovMini()
    {
        minibossAnim.SetBool("Walking", true);
        rb.transform.position = Vector3.MoveTowards(rb.position, new Vector3(objetivo.position.x, objetivo.position.y, 0), velocity * Time.deltaTime);
        if (objetivo.position.x < rb.position.x)
        {
            minibossAnim.SetBool("MovIzq", true);
        }
        else if (objetivo.position.x >= rb.position.x)
        {
            minibossAnim.SetBool("MovIzq", false);
        }


        Invoke("DeathMiniBoss", 18f);
    }
    public void WakeUp()
    {
        minibossAnim.SetBool("Alerta", true);
    }
    public void LetsWalk()
    {
        minibossAnim.SetBool("LetsWalk", true);
    }

    public void DeathMiniBoss()
    {
        Destroy(this.gameObject);
        Instantiate(particles, transform.position, Quaternion.identity);
    }
}
