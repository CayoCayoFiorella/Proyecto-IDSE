using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNave : MonoBehaviour
{
    public float velocidad = 60.0f; // Velocidad de movimiento de la nave

    // Start is called before the first frame update
    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        procesarInput();
    }

    private void procesarInput()
    {
        Mover();
    }

    private void Mover()

    {
        Vector3 direccion = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direccion += Vector3.up; // Mover hacia arriba
        }
        if (Input.GetKey(KeyCode.S))
        {
            direccion += Vector3.down; // Mover hacia abajo
        }
        if (Input.GetKey(KeyCode.A))
        {
            direccion += Vector3.left; // Mover hacia la izquierda
        }
        if (Input.GetKey(KeyCode.D))
        {
            direccion += Vector3.right; // Mover hacia la derecha
        }

        if (direccion != Vector3.zero)
        {
            rigidbody.velocity = direccion.normalized * velocidad; // Mover en la dirección calculada
        }
        else
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }

}