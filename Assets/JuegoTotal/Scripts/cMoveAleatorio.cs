using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class cMoveAleatorio : MonoBehaviour
{
    public Transform[] puntosRuta;
    public float velocidadMovimiento = 3f;
    private int indicePuntoActual = 0;
    private int direccion = 1;
 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoverPorRuta());
    }
 
    IEnumerator MoverPorRuta()
    {
        while (true)
        {
            // Obtén un índice de punto aleatorio
            int indicePuntoAleatorio = Random.Range(0, puntosRuta.Length);
 
            // Asegúrate de que el índice aleatorio no sea igual al índice actual
            while (indicePuntoAleatorio == indicePuntoActual)
            {
                indicePuntoAleatorio = Random.Range(0, puntosRuta.Length);
            }
 
            Vector3 siguientePunto = puntosRuta[indicePuntoAleatorio].position;
            transform.LookAt(siguientePunto);
 
            while (transform.position != siguientePunto)
            {
                transform.position = Vector3.MoveTowards(transform.position, siguientePunto, velocidadMovimiento * Time.deltaTime);
                yield return null;
            }
 
            indicePuntoActual = indicePuntoAleatorio;
        }
    }
}
