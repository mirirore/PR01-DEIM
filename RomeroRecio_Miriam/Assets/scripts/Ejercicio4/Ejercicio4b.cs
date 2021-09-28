using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4b : MonoBehaviour
{
    //Variable de velocidad para ambos ejes
    public float speed = 2.0f;


    // Update is called once per frame
    void Update()
    {
        //eje vertical con velocidad
        
        float DesplY = Input.GetAxis("Vertical") * speed;
        
        //Movemos el objeto usando el método UP incluido en el Vector3
        transform.Translate(Vector3.up * DesplY * Time.deltaTime);
        
        //eje horizontal con velocidad
       
        float DesplX = Input.GetAxis("Horizontal") * speed;

        //Movemos el objeto usando el método LEFT incluido en el Vector3
        transform.Translate(Vector3.left * DesplX * Time.deltaTime);

        //RESTRICCION
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10f, 10f), Mathf.Clamp(transform.position.y, -4f,5f), 0);
        



    }
}
