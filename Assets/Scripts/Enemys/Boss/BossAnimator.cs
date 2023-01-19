using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimator : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] Rigidbody2D _rbPj;
    float                        _time;
    [SerializeField] GameObject  _hit;
    public Animator    anim;
    HealthEnemys _boss;
    Scenes _sc;
   

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Attack", true);
        _boss = GetComponent<HealthEnemys>();
        _sc = GameObject.Find("Canvas").GetComponent<Scenes>();
    }



    public void WinWin()
    {
        _sc.SceneWin();
    }


}
