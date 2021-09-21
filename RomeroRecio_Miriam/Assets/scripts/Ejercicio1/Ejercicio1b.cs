using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1b : MonoBehaviour
{
    public string yo = "miri";
    public int x = 3;
    public float y = 2f;
    public bool z = true;

    // Start is called before the first frame update
    void Start()
    {
        yo = "laura";
        print(yo);

        x = 7;
        print(x);

        y = 20;
        print(y);

        z = false;
        print(z);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
