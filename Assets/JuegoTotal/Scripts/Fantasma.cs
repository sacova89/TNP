using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    public float velocidadMovimiento = 2f;
    public float tiempoEsperaMinimo = 1f;
    public float tiempoEsperaMaximo = 3f;

    private Vector3[] direccionesPosibles = { Vector3.forward, Vector3.back, Vector3.left, Vector3.right };
    private Vector3 direccionActual;
    private bool enMovimiento;

    void Start()
    {
        StartCoroutine(CambiarDireccionAleatoria());
    }

    void Update()
    {
        if (!enMovimiento)
            return;

        transform.Translate(direccionActual * velocidadMovimiento * Time.deltaTime);
    }

    IEnumerator CambiarDireccionAleatoria()
    {
        while (true)
        {
            float tiempoEspera = Random.Range(tiempoEsperaMinimo, tiempoEsperaMaximo);
            yield return new WaitForSeconds(tiempoEspera);

            direccionActual = direccionesPosibles[Random.Range(0, direccionesPosibles.Length)];

            while (!PuedeMoverEnDireccion(direccionActual))
            {
                direccionActual = direccionesPosibles[Random.Range(0, direccionesPosibles.Length)];
            }

            enMovimiento = true;
        }
    }

    bool PuedeMoverEnDireccion(Vector3 direccion)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direccion, out hit, 1f))
        {
            return hit.collider.CompareTag("Pared");
        }
        return true;
    }
}