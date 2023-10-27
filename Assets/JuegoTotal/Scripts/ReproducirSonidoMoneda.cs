using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproducirSonidoMoneda : MonoBehaviour
{
    public AudioClip sonidoMoneda;
    private AudioSource audioSource;

    private void Start()
    {
        // Obtén una referencia al componente AudioSource en este objeto.
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto colisionado tiene el tag "Puntos" y un BoxCollider.
        if (other.CompareTag("Puntos") && other is BoxCollider)
        {
            // Reproduce el sonido de moneda cuando ocurre la colisión.
            if (audioSource != null && sonidoMoneda != null)
            {
                audioSource.PlayOneShot(sonidoMoneda);
            }
        }
    }
}
