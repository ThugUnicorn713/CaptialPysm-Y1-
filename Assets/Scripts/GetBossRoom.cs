using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBossRoom : MonoBehaviour
{
    Camera cam;
    public GameObject playerObject;

    private void Start()
    {
            cam = playerObject.GetComponentInChildren<Camera>();
    }
  
  
    public void SendToBoss()
    {
        RoomGenerator.GetInstance().GetBossRoom();

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
