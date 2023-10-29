using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Weak : MonoBehaviour
{
    [SerializeField] private GameObject youLosePanel;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject scoreTextGO;
    [SerializeField] private GameObject scoreTextTittleGO;

    [SerializeField] private AudioSource loseSoundEffect;


    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fantasma"))
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
            youLosePanel.SetActive(true);
            scoreTextGO.SetActive(false);
            scoreTextTittleGO.SetActive(false);
            pauseButton.SetActive(false);
            loseSoundEffect.Play();


        }
     
    }

}