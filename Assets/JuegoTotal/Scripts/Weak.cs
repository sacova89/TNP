using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Weak : MonoBehaviour
{
    public string sceneToLoad;
    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fantasma"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene (sceneToLoad);
            
        }
     
    }

    private void Update()
    {
        
    }
}
