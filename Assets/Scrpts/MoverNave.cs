using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNave : MonoBehaviour
{
    public float velocidad = 2f; // Velocidad de movimiento de la nave

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
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddRelativeForce(Vector3.up*velocidad);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddRelativeForce(Vector3.down*velocidad);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddRelativeForce(Vector3.left*velocidad);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddRelativeForce(Vector3.right*velocidad);
        }
        else if(!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)){
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
}
