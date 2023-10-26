using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportRight : MonoBehaviour
{

    [SerializeField] private GameObject playerToLeft;

    private void OnTriggerEnter(Collider other)
    {

        other.CompareTag("Player");
        playerToLeft.transform.position = new Vector3(-9.739f, 0.50f, -0.608f);


    }
}