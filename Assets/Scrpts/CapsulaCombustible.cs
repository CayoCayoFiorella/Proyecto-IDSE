using UnityEngine;

public class CapsulaCombustible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("nave")) // Verifica que el objeto que colisiona tiene el tag "nave"
        {
            // Obtener el script de combustible de la nave
            Combustible combustibleNave = other.GetComponentInParent<Combustible>();

            if (combustibleNave != null)
            {
                combustibleNave.RecargarCombustible();
                Destroy(gameObject); // Destruir la cápsula de combustible solo cuando la nave colisiona
            }
        }
    }
}
