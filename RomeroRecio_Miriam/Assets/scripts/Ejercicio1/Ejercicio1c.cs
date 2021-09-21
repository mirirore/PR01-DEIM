using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1c : MonoBehaviour
{
    [SerializeField] float num1 = 5f;
    [SerializeField] float num2 = 5f;
    private float resultado;

    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 * num2;
        print(resultado);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
