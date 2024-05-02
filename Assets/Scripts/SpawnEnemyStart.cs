using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemyStart : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;


    private void Start()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);

        }

    }


}
