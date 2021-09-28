using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio4a : MonoBehaviour

{
    public Text MyText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("contador");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator contador()
    {
        for (int n = 0; n<=20 ; n++)
        {
            MyText.text = "numero:" + n;
            yield return new WaitForSeconds(1f);
            

        }
    }
}
