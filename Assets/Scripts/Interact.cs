using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject playerObject;
   
    Camera cam;

    private void Update()
    {
        if (cam == null)
        {
            cam = playerObject.GetComponentInChildren<Camera>();
        }
        
       
    }

    public void SendToRoom() {
        RoomGenerator.GetInstance().GetRoom();

        Vector3 position = RoomGenerator.GetInstance().FindPlayerPosition();
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
