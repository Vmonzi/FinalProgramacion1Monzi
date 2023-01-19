using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapaBoss : MonoBehaviour
{
    CanvasChap chap;

   private void Start()
   {
        chap = GetComponent<CanvasChap>();
        chap.boss = 1;
   }
}
