using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproducirAudioEnTrigger : MonoBehaviour
{
    public string tagObjetivo = "Puntos"; // El tag del objeto que queremos detectar.
    public AudioClip audioACargar; // El audio que se reproducirá.

    private void OnTriggerEnter(Collider other)
    {
        // Comprobamos si el objeto que entra en el trigger tiene el tag "fantasma".
        if (other.CompareTag(tagObjetivo))
        {
            // Reproducimos el audio.
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null && audioACargar != null)
            {
                audioSource.clip = audioACargar;
                audioSource.Play();
            }
        }
    }
}
