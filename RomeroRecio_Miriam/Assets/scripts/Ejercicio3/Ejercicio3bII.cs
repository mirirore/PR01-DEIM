using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3bII : MonoBehaviour
{
    [SerializeField] float n1;
    [SerializeField] float n2;
    [SerializeField] string operacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calculadora Unity

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Calcular(n1, n2,operacion);
        }
    }

    void Calcular(float num1, float num2,string operacion)
    {
        float resultado = 0f;
        if(operacion=="dividir")
            {
            resultado = num1 / num2;
           
            }
        else if (operacion=="restar")
            {
            resultado = num1 - num2;
            
            }
        else if (operacion=="sumar")
        {
            resultado = num1 + num2;
            
        }

        else //porque es la última opción que queda
        {
            resultado = num1 * num2;
            
        }

        print(resultado);

        //
    }
}
