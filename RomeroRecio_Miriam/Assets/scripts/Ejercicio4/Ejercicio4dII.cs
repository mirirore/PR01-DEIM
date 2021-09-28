using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4dII : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("autodisparo");
    }

    // Update is called once per frame
    void Update()
    {
       //dando a tecla Space
       if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("autodisparo");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine("autodisparo");
        }

    }

    IEnumerator autodisparo()
    {
        for (int n=1; ;n++)
        {
            yield return new WaitForSeconds(1f);
            print("pium"+ n);

        }

    }

}
