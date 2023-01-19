using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BayasUI : MonoBehaviour
{
    public Image baya1Off;
    public Image baya2Off;
    public Image baya1On;
    public Image baya2On;
    public Image baya1Select;
    public Image baya2Select;
    Bayas _bayas;


    private void Start()
    {
        baya1Off.enabled = enabled;
        baya2Off.enabled = enabled;
        baya1On.enabled = !enabled;
        baya2On.enabled = !enabled;
        baya1Select.enabled = !enabled;
        baya2Select.enabled = !enabled;
    }
    public void Baya1Off()
    {
        baya1Off.enabled = enabled;
        baya1On.enabled = !enabled;
        baya1Select.enabled = !enabled;

    }
        public void Baya2Off()
    {
        baya2Off.enabled = enabled;
        baya2On.enabled = !enabled;
        baya2Select.enabled = !enabled;
    }
    public void Baya1()
    {
        baya1On.enabled = enabled;
    }

    public void Baya2()
    {
        baya2On.enabled = enabled;
    }

    public void Baya1Select()
    {
        baya1Select.enabled = enabled;
        baya2Select.enabled = !enabled;
    }

    public void Baya2Select()
    {
        baya2Select.enabled = enabled;
        baya1Select.enabled = !enabled;
    }

    private void Update()
    {
        
    }
}
