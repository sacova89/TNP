using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string mainMenu; // Asigna el nombre de la escena que deseas cargar en el Inspector.

    public void CambiarAEscena()
    {
        // Carga la escena especificada por su nombre.
        SceneManager.LoadScene(mainMenu);
        Time.timeScale = 1f;
    }
}