using UnityEngine;
using UnityEngine.UI;

public class vidas : MonoBehaviour
{
    public int v = 3; // Vidas iniciales
    public Image[] vidasImages; // Referencia a las imágenes de vidas en el HUD
    public Canvas endGameCanvas; // Referencia al Canvas de End Game
    private ParticleSystem particulasDestruccion;

    void Start()
    {
        // Inicializar las imágenes de vidas
        ActualizarVidasUI();
        particulasDestruccion = GetComponentInChildren<ParticleSystem>();

        if (particulasDestruccion == null)
        {
            Debug.LogError("No se encontró el sistema de partículas de destrucción.");
        }
        else
        {
            Debug.Log("Sistema de partículas encontrado: " + particulasDestruccion.name);
        }

        if (endGameCanvas != null)
        {
            endGameCanvas.gameObject.SetActive(false); // Asegurarse de que esté desactivado al inicio
        }
        else
        {
            Debug.LogError("No se encontró el Canvas de End Game.");
        }
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
            if (particulasDestruccion != null)
            {
                Debug.Log("Activando partículas de destrucción.");
                particulasDestruccion.Play(); // Activar las partículas de destrucción
            }
        }

        if (v <= 0)
        {
            Debug.Log("¡La nave ha sido destruida!");
            PausarJuego();
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

    void PausarJuego()
    {
        Time.timeScale = 0; // Pausar el juego
        Debug.Log("Juego Pausado.");

        if (endGameCanvas != null)
        {
            endGameCanvas.gameObject.SetActive(true); // Mostrar el Canvas de End Game
        }
    }
}
