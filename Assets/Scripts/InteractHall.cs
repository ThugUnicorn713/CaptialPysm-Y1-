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
        Debug.Log("Transform passed: | " + tform);
        if (transform != null)
        {
            Debug.Log("This is where the player is now:" + playerObject.transform.position);
            // Set the player's position to the empty GameObject
            playerObject.transform.position = tform.position;
            //playerObject.transform.rotation = tform.rotation;

            Debug.Log("This is where I think the player is:" + playerObject.transform.position);
        }
        else
        {
            Debug.LogWarning("No empty GameObject found inside the spawned object.");
        }
    }

}