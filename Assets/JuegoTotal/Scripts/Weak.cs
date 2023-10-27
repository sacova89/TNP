using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Weak : MonoBehaviour
{
    [SerializeField] private GameObject youLosePanel;
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
            
        }
     
    }

    private void Update()
    {
        
    }
}