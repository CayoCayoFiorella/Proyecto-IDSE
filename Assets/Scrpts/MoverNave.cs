using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNave : MonoBehaviour
{
    public float velocidad = 10f; // Velocidad de movimiento de la nave

    // Start is called before the first frame update
    void Start()
    {
        
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
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}
