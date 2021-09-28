using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3cReloj : MonoBehaviour
{
    //Variables
    int segundos;
    int minutos;
    int horas;
    string textoFinal;

    // Start is called before the first frame update
    void Start()
    {
       
        segundos = 0;
        minutos = 0;
        horas = 0;
        
        StartCoroutine("reloj");
    }


    IEnumerator reloj()
    {
        
        for (int n=0; ; n++)
        {
            segundos++;

            //minutos
            if (segundos > 59)
            {
                minutos++;
                segundos = 0; 
            }

            
            //hora
            if (minutos > 59)
            {
                horas++;
                minutos = 0;
            }

            //Variable para que tengan dos dígitos
            string segundosSt = segundos.ToString("D2");
            string minutesSt = minutos.ToString("D2");
            string horasSt = horas.ToString("D2");

            //texto final pantalla
            textoFinal = horasSt + ":" + minutesSt + ":" + segundosSt;
            print(textoFinal);
            yield return new WaitForSeconds(1f);

        }

    }
}


