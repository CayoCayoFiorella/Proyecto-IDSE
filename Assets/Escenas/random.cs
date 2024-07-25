using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomMover : MonoBehaviour
{
    public float moveSpeed = 2.0f;         // Velocidad del movimiento
    public float range = 5.0f;             // Rango dentro del cual el objeto se moverá

    private Vector3 targetPosition;        // Posición objetivo hacia la que el objeto se moverá

    void Start()
    {
        // Asignar una posición inicial aleatoria al objeto
        targetPosition = GetRandomPosition();
    }

    void Update()
    {
        // Mover el objeto hacia la posición objetivo
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Si el objeto ha alcanzado la posición objetivo, asignar una nueva posición objetivo aleatoria
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            targetPosition = GetRandomPosition();
        }
    }

    // Método para obtener una posición aleatoria dentro del rango especificado
    Vector3 GetRandomPosition()
    {
        float randomX = Random.Range(-range, range);
        float randomY = Random.Range(-range, range);
        float randomZ = Random.Range(-range, range);
        return new Vector3(randomX, randomY, randomZ);
    }
}
