using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectWithSoundAndAnimation : MonoBehaviour
{
    public AudioClip destructionSoundClip;
    public GameObject destructionEffect;

    private bool isDestroyed = false;
    private AudioSource audioSource;

    void Start()
    {
        // Busca un componente AudioSource en el objeto actual.
        audioSource = GetComponent<AudioSource>();
    }

    void OnDestroy()
    {
        if (!isDestroyed)
        {
            if (destructionSoundClip != null && audioSource != null)
            {
                // Establece el volumen del AudioSource a 0 para que el sonido sea inaudible.
                audioSource.volume = 0;

                // Asigna el clip al AudioSource si aún no se ha asignado.
                if (audioSource.clip == null)
                {
                    audioSource.clip = destructionSoundClip;
                }

                // Reproduce el sonido.
                audioSource.Play();

                // Restaura el volumen original después de reproducir el sonido.
                audioSource.volume = 1;
            }

            if (destructionEffect != null)
            {
                Instantiate(destructionEffect, transform.position, transform.rotation);
            }

            isDestroyed = true;
        }
    }
}
