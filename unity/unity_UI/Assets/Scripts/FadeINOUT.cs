using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FadeINOUT : MonoBehaviour
{

     void Awake()
    {
            
    }

    private void Start()
    {

    }
    // Start is called before the first frame update
    public void FadeOUT_List(Image fadeimg)
    {
        StartCoroutine(CoFadeOut(fadeimg));
    }

    public IEnumerator CoFadeOut(Image fadeimg)
    {
        Color tempColor = new Color(0, 0, 0, 0);
     

        while (tempColor.a < 1.0f)
        {
            tempColor.a += 1 * Time.deltaTime;


            fadeimg.color = tempColor;
            yield return null;

        }
        yield return null;


    }
    public void FadeIN_List(Image fadeimg)
    {
        StartCoroutine(CoFadeIN(fadeimg));
    }
    IEnumerator CoFadeIN(Image fadeimg)
    {
        Color tempColor = new Color(0, 0, 0, 1);


        while (tempColor.a > 0)
        {
            tempColor.a -= 1 * Time.deltaTime;

            fadeimg.color = tempColor;
            
            yield return null;
        }
        yield return null;
    }
}
