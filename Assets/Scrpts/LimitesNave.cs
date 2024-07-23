using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitesNave : MonoBehaviour
{
    public Vector3 minBounds; // El mínimo valor x, y, z que la nave puede alcanzar
    public Vector3 maxBounds; // El máximo valor x, y, z que la nave puede alcanzar

    void Update()
    {
        // Restringir la posición de la nave dentro de los límites especificados
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, minBounds.x, maxBounds.x);
        pos.y = Mathf.Clamp(pos.y, minBounds.y, maxBounds.y);
        pos.z = Mathf.Clamp(pos.z, minBounds.z, maxBounds.z);
        transform.position = pos;
    }
}
