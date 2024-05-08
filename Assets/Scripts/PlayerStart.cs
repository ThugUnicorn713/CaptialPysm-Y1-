using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    [SerializeField] private Vector3 playerStart;

     void Awake()
     {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = playerStart; 
     }
}
