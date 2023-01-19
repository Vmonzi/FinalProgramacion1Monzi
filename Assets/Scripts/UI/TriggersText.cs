using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersText : MonoBehaviour
{
    [SerializeField] GameObject _text;
    Scenes                      _sc;
    Puntos                      _pts;
    bool                        _boss;
    bool                        _miniboss;

    private void Start()
    {
       _sc = GameObject.Find("Canvas").GetComponent<Scenes>();
       _pts = GameObject.Find("Canvas").GetComponent<Puntos>();
       _text.SetActive(false);
       _boss = false;
       _miniboss = false;
    }

    private void Update()
    {
        if (_boss)
        {
            _sc.GolevelBoss();
        }
        else if (_miniboss)
        {
            _sc.GolevelMiniBoss();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_pts.puntosTotales == 10 && this.gameObject.name == ("TextoBoss"))
        {
            _text.SetActive(true);
            _boss = true;
          
        }

        if (_pts.puntosTotales >= 9 && this.gameObject.name == ("TextoMini"))
        {
            _text.SetActive(true);
            _miniboss = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _text.SetActive(false);
    }
}
