using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ejercicio4a : MonoBehaviour

{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            StartCoroutine("contador");
        }

        if (Input.GetKeyDown(KeyCode.Return))

        {
            StopCoroutine("contador");
        }
    }

    IEnumerator contador()
    {

        for (int n = 0; ; n++)
        {
            print(n);
            yield return new WaitForSeconds(1f);
            

        }
    }
}
