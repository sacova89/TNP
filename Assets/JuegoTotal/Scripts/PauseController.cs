
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{    
    [SerializeField] GameObject pauseMenu;  // Panel de pausa
    [SerializeField] GameObject resumeButton; // Botón de "Resume"
    [SerializeField] private GameObject menuPanel;

    public void Pause()
    {
        // Desactiva el panel de pausa y activa el botón de "Resume"
        pauseMenu.SetActive(false);
        resumeButton.SetActive(true);
        Time.timeScale = 0f;
        menuPanel.SetActive(true);
    }

    public void Resume()
    {
        // Activa el panel de pausa y desactiva el botón de "Resume"
        pauseMenu.SetActive(true);
        resumeButton.SetActive(false);
        Time.timeScale = 1f;
        menuPanel.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
