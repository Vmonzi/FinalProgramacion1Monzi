using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasChap : MonoBehaviour
{
    public Image chapita;
    public float boss = 0;

    private void Update()
    {
       if (boss == 1)
       {
        chapita.enabled = true;
       }
      else
      {
          chapita.enabled = false;
      }
    }
    public void SetChapitaOn()
    {
        chapita.enabled = true;
        
    }
}
