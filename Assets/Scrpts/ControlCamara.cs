using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public Transform objetivoASeguir;
    public Vector3 offesset = new Vector3(-884, -466, -298);

    // Update is called once per frame

    private void Start()
    {

    }

    void Update()
    {
        if (objetivoASeguir != null)
        {
            Vector3 posicionObjetivo = objetivoASeguir.position + offesset;
            posicionObjetivo.x = transform.position.x;
            transform.position = Vector3.Lerp(transform.position, posicionObjetivo, Time.deltaTime * 5f);

        }
    }
}