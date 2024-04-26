using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBossRoom : MonoBehaviour
{

    [SerializeField] private bool triggerActive = false;
    public GameObject playerObject;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.E))
        {
            PressE();
            RoomGenerator.GetInstance().GetBossRoom();

            if (triggerActive == true)
            {

                Vector3 position = RoomGenerator.GetInstance().FindPlayerBossPosition();
                if (position != Vector3.zero)
                {
                    // Set the player's position to the empty GameObject
                    playerObject.transform.position = position;
                }
                else
                {
                    Debug.LogWarning("No empty GameObject found inside the spawned object.");
                }

            }
        }
    }

    public void PressE()
    {
        Debug.Log("I have been touched " + gameObject.name);
    }



}
