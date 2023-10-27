using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowMe : MonoBehaviour
{
    public Transform target2;
    Vector3 dest2;
    NavMeshAgent agente2;

    void Start()
    {
        agente2 = GetComponent<NavMeshAgent>();
        dest2 = agente2.destination;
    }

    // Update is called once per frame
    void Update()
    {
        if (target2 != null) // Comprueba si target2 no es nulo antes de acceder a su posición.
        {
        if (Vector3.Distance(dest2, target2.position) > 1.0f)
        {
            dest2 = target2.position;
            agente2.destination = dest2;
        }
        }
    }
}
