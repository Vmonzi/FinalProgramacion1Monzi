using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinibossMovement : MonoBehaviour
{
    public Animator                 minibossAnim;
    public float                    velocity;
    public Rigidbody2D              rb;
    public Rigidbody2D              rbPj;
    public DroppChapa               chapita;
    public GameObject               ch;
    public Rigidbody2D              chap;
    [SerializeField] GameObject    _text1;
    [SerializeField] GameObject    _text2;
    [SerializeField] GameObject    _text3;




    void Start()
    {
        minibossAnim = GetComponent<Animator>();
        chapita = GetComponent<DroppChapa>();
        ch.SetActive(false);
        _text1.SetActive(false);
        _text2.SetActive(false);
        _text3.SetActive(false);

    }

    void Update()
    {
        if (minibossAnim.GetBool("Alerta") == true && minibossAnim.GetBool("Ataque") == false && minibossAnim.GetBool("Death") == false && minibossAnim.GetBool("LetsWalk") == true)
        {
            MovMini();
        }
    }

    public void Text1()
    {
        _text1.SetActive(true);
        _text2.SetActive(false);
        _text3.SetActive(false);
    }
    public void Text2()
    {
        _text1.SetActive(false);
        _text2.SetActive(true);
        _text3.SetActive(false);
    }
    public void Text3()
    {
        _text1.SetActive(false);
        _text2.SetActive(false);
        _text3.SetActive(true);
    }
    public void StopText()
    {
        _text1.SetActive(false);
        _text2.SetActive(false);
        _text3.SetActive(false);
    }

    public void MovMini()
    {
            minibossAnim.SetBool("Walking", true);
           rb.transform.position = Vector3.MoveTowards(rb.position, new Vector3(rbPj.position.x, rbPj.position.y, 0), velocity * Time.deltaTime);
             if (rbPj.position.x < rb.position.x)
             {
               minibossAnim.SetBool("MovIzq", true);
             }
            else if(rbPj.position.x >= rb.position.x)
            {
               minibossAnim.SetBool("MovIzq", false);
            } 
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
    }

    public void Chapita()
    {
        chapita.Spawn();
    }

    public void StartCh()
    {
        ch.SetActive(true);
    }
    public void Velocity()
    {
        velocity -= 25;
    }
}
