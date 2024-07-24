using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Necesario para trabajar con UI

public class Combustible : MonoBehaviour
{
    public float combustible = 100f; // Nivel de combustible inicial
    public float consumoPorSegundo = 5f; // Cantidad de combustible consumida por segundo
    public Image imagenCombustibleFrontal; // Referencia a la imagen frontal de la barra de combustible

    void Update()
    {
        ActualizarCombustible();
    }

    private void ActualizarCombustible()
    {
        // Reducir el combustible incluso si no se presiona ninguna tecla
        combustible -= consumoPorSegundo * Time.deltaTime;

        // Asegurate de que el combustible no sea negativo
        if (combustible < 0)
        {
            combustible = 0;
        }

        // Actualiza la imagen frontal de la barra de combustible
        if (imagenCombustibleFrontal != null)
        {
            imagenCombustibleFrontal.fillAmount = combustible / 100f;
        }
    }

    // Metodo para recargar el combustible por completo
    public void RecargarCombustible()
    {
        combustible = 100f;
    }

    // Metodo para comprobar si hay combustible disponible
    public bool TieneCombustible()
    {
        return combustible > 0;
    }
}


