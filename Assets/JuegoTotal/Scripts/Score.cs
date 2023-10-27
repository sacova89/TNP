using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int Puntaje = 0;
    public GameObject cherry;
    public TMP_Text scoreT;
    

    [SerializeField] private GameObject youWinPanel;


    private void Update()
    {
        if(Puntaje >= 15)
        {
            cherry.SetActive(true);
        } 
        else
        {
            cherry.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Puntos"))
        {
            Destroy(other.gameObject);
            Puntaje++;
            scoreT.text = "Score: " + Puntaje;
        }

        if(other.gameObject.CompareTag("Cherry"))
        {
            cherry.SetActive(false);
            scoreT.text = "GANASTE!";
            Time.timeScale = 0f;
            youWinPanel.SetActive(true);
        }
    }
 }