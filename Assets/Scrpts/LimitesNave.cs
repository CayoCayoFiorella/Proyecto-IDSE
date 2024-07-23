using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitesNave : MonoBehaviour
{
    public Vector3 minBounds; // El m�nimo valor x, y, z que la nave puede alcanzar
    public Vector3 maxBounds; // El m�ximo valor x, y, z que la nave puede alcanzar

    void Update()
    {
        // Restringir la posici�n de la nave dentro de los l�mites especificados
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, minBounds.x, maxBounds.x);
        pos.y = Mathf.Clamp(pos.y, minBounds.y, maxBounds.y);
        pos.z = Mathf.Clamp(pos.z, minBounds.z, maxBounds.z);
        transform.position = pos;
    }
}
