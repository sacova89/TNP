using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("LevelONE", LoadSceneMode.Single);
        Debug.Log("Cargar el juego PAPUU");
    }



}
