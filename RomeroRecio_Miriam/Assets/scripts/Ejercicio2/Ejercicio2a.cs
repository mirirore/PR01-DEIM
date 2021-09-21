using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2a : MonoBehaviour
{
    private int n=0;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()

    {
        n++;
        if (n < 10)
        { 
            print(n);
        }
        else if (n==10)
        {
            print("FIN");
        }
    }
}
