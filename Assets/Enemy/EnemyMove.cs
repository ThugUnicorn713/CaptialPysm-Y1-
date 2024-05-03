using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{

    public Transform player;
    public NavMeshAgent agent;
    [SerializeField] float sight = 5f; 

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < sight)
        {
            agent.destination = player.position;
        }
    }
}
