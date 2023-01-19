using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PjHealth : MonoBehaviour
{
    public float        actualHealth;
    public float        baseHealth;
    private Movement    _charlyMov;
    public GameObject    blood;
    public GameObject    bloodTarget;
    public AudioClip     hurt;
    public AudioSource   myAudio;
    private void Start()
    {
        baseHealth = 0;
         actualHealth = baseHealth;
        _charlyMov = GetComponent<Movement>();
         Hurt();
    }

    public void attackEnemys(int EnemysDamage)
    {
        if (actualHealth < 100)
            
        {
            myAudio.clip = hurt;
            myAudio.Play();
            actualHealth += EnemysDamage;
            _charlyMov.myAnimator.SetBool("Hurt", true);
            Instantiate(blood, bloodTarget.transform.position, Quaternion.identity);

            if (actualHealth >= 100)
            {
                _charlyMov.myAnimator.SetBool("Death",true);
                SceneManager.LoadScene("Lose");
                
            }
        
        }

    } 
    public void Hurt ()
    {
        _charlyMov.myAnimator.SetBool("Hurt", false);
        myAudio.Stop();
    }

    private void Update()
    {
        if (actualHealth <= 0)
        {
            actualHealth = 0;
        }
    }

  
}
