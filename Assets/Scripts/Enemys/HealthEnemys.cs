using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemys : MonoBehaviour
{
    public int enemysHealth;
    public Animator enemysAnimator;
    public AudioSource myAudio;
    public AudioClip   hurt;


    private void Start()
    {
        myAudio.clip = hurt;
    }
    public void attackPJ(int PjDamage)
    {
        if (enemysHealth > 0)

        {
            myAudio.Play();
            enemysHealth -= PjDamage;
            enemysAnimator.SetBool("Hurt", true);
            enemysAnimator.SetBool("Attack", false);
            enemysAnimator.SetBool("AreaAttack", false);

            if (enemysHealth <= 0)
            {
                enemysAnimator.SetBool("Walking", false);
                enemysAnimator.SetBool("Death", true);
                enemysAnimator.SetBool("Hurt", false);

            }
        }
    }
    public void Hurt()
    {
        enemysAnimator.SetBool("Hurt", false);
        myAudio.Stop();
    }

    public void Muerte()
    {
        enemysHealth = 0;
        enemysAnimator.SetBool("Walking", false);
        enemysAnimator.SetBool("Death", true);
        enemysAnimator.SetBool("Hurt", false);
    }

    public void DestroyBoss()
    {
        Destroy(this.gameObject);
    }
}
