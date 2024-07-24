using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vidas : MonoBehaviour
{
    public int v = 3;
    public Image[] vidasImages; // Referencia a las imágenes de vidas en el HUD

    void Start()
    {
        // Inicializar las imágenes de vidas
        ActualizarVidasUI();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("meteorito") || collision.gameObject.layer == LayerMask.NameToLayer("Satelite"))
        {
            PerderVida();
        }
    }

    void PerderVida()
    {
        if (v > 0)
        {
            v--;
            ActualizarVidasUI();
        }

        if (v <= 0)
        {
            Debug.Log("¡La nave ha sido destruida!");
            // Aquí puedes añadir lógica para destruir la nave, reiniciar el nivel, etc.
        }
    }

    void ActualizarVidasUI()
    {
        for (int i = 0; i < vidasImages.Length; i++)
        {
            if (i < v)
            {
                vidasImages[i].enabled = true; // Mostrar imagen de vida
            }
            else
            {
                vidasImages[i].enabled = false; // Ocultar imagen de vida
            }
        }
    }
}
