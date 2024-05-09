using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemyStart : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject enemy;
    public Transform[] spawnPoints;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerObject)
        {
            SpawnEnemies();
            gameObject.SetActive(false);
        }
    }
    void SpawnEnemies()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            GameObject enemyInst =  Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            EnemyMove move = enemyInst.GetComponent<EnemyMove>();
            move.player = playerObject.transform;

        }

    }


}
