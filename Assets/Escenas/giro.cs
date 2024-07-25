using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giro : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        // Gira el objeto en su propio eje Y a la velocidad especificada
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
