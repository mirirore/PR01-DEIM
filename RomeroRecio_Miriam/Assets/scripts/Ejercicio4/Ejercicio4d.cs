using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4d : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("disparo pulsado");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("disparo liberado");
        }
    }
}
