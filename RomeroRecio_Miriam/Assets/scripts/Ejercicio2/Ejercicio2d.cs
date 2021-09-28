using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2d : MonoBehaviour
{
    private int aleatorio;
    public int numpropio = 7;
    // Start is called before the first frame update
    void Start()
    {
        while (aleatorio!=numpropio)
        {
            aleatorio = Random.Range(0,10);
            print(aleatorio);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
