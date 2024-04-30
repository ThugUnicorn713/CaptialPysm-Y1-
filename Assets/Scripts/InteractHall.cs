using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractHall : MonoBehaviour
{
    Camera cam;
    public GameObject playerObject;

    private void Start()
    {
        cam = playerObject.GetComponentInChildren<Camera>();
    }

    public void SendToHall()
    {
        RoomGenerator.GetInstance().GetHall();

        Transform tform = RoomGenerator.GetInstance().FindPlayerHallPosition();
        if (transform != null)
        {
            // Set the player's position to the empty GameObject
            playerObject.transform.position = tform.position;
            playerObject.transform.rotation = tform.rotation;
        }
        else
        {
            Debug.LogWarning("No empty GameObject found inside the spawned object.");
        }
    }

}