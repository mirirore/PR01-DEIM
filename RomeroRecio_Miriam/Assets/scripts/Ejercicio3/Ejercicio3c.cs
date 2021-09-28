using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class Ejercicio3c : MonoBehaviour
{
    public Text MyText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("contador");
    }



    IEnumerator contador ()
    {
        for (int n=0; ;n++)
        {
            if (n >= 7)
            {
                StopCoroutine("contador");
            }
           
            MyText.text = "numero:" + n;
            yield return new WaitForSeconds(1f);

            
        }
    }
}
