using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4aSingle : MonoBehaviour
{ 

    bool encendido = false; //por que al empezar está apagado, luego estar encendido es false

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            if(encendido==false)
            {
                StartCoroutine("contador");
                encendido = true;
            }
            else
            {
                StopCoroutine("contador");
                encendido = false;
            }
            
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

