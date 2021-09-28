using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3a : MonoBehaviour
{
    //public string persona;
    public string me = "miriam";


    // Start is called before the first frame update
    void Start()
    {
        // saludar(persona);
        saludar(me);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void saludar(string persona)
    {
        print("Hola");
    }
    */

    void saludar(string me)
    {
        print("Hola" + me);
    }
}
