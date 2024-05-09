using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnObjects : MonoBehaviour
{
    public GameObject spawnTrigger;
    public GameObject interFace;
    public GameObject playerObject;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerObject)
        {
            if (!spawnTrigger.activeSelf)
            {
                spawnTrigger.SetActive(true);

            }

            if (!interFace.activeSelf) 
            {
                interFace.SetActive(true);
            }
        }
    }

}
    

    

