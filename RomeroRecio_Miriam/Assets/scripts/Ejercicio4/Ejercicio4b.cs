using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4b : MonoBehaviour
{
   
    public float speed = 2.0f;


    // Update is called once per frame
    void Update()
    {
        
        float DesplY = Input.GetAxis("Vertical") * speed;
        
       transform.Translate(Vector3.up * DesplY * Time.deltaTime);
        
       
       
        float DesplX = Input.GetAxis("Horizontal") * speed;

      
        transform.Translate(Vector3.left * DesplX * Time.deltaTime);

        //RESTRICCION
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10f, 10f), Mathf.Clamp(transform.position.y, -4f,5f), 0);
        



    }
}
