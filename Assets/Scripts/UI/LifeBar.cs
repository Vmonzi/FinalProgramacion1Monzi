using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Image lifepj;
    public PjHealth life;

    private void Start()
    {
        life = GetComponent<PjHealth>();
    }
    void Update()
    {
        lifepj.fillAmount = life.actualHealth/100;
    }
}
