using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportLeft : MonoBehaviour
{

    [SerializeField] private GameObject playerToRight;

    private void OnTriggerEnter(Collider other)
    {

        other.CompareTag("Player");
        playerToRight.transform.position = new Vector3(9.927f, 0.50f, -0.527f);


    }
}
