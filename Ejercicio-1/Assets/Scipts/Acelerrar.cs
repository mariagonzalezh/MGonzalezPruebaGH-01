using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerrar : MonoBehaviour
{
    Rigidbody rbCarro;

    [SerializeField]
    private float velocidad, sensibilidad;


    void Start()
    {
        rbCarro = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rbCarro.AddForce(0,0, velocidad * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rbCarro.AddForce(sensibilidad * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rbCarro.AddForce(-sensibilidad * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
