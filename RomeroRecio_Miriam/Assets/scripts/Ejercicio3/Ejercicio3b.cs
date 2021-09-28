using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3b : MonoBehaviour
{
    private bool laBooleana;
    [SerializeField] float num1 = 10f;
    [SerializeField] float num2 = 5f;
    private float resultado;

    // Start is called before the first frame update
    void Start()
    {
        Sumar(num1, num2);

        if (resultado >=15)
        {
            laBooleana = true;
        }

        else
        {
            laBooleana = false;
        }
        print("El resultado es:" + laBooleana);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Sumar ( float num1, float num2)
    {
        resultado = num1 + num2;
       
    }

}
