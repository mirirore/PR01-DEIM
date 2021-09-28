using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4c : MonoBehaviour
{
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        float DesplZ = Input.GetAxis("Vertical") * speed;

        transform.Translate(Vector3.forward * DesplZ * Time.deltaTime);
    }
}
