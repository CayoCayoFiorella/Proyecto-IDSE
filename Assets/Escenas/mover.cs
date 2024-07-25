using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float speed = 2.0f;         // Velocidad del movimiento
    public float distance = 3.0f;      // Distancia máxima a mover desde el punto inicial

    private Vector3 startPos;          // Posición inicial del objeto

    void Start()
    {
        // Guardar la posición inicial del objeto
        startPos = transform.position;
    }

    void Update()
    {
        // Calcular la nueva posición del objeto
        float offset = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(startPos.x + offset, startPos.y, startPos.z);
    }
}
