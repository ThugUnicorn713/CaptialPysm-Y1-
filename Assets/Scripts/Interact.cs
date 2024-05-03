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

        Transform tform = RoomGenerator.GetInstance().FindPlayerPosition();
        if (tform != null)
        {
            CharacterController characterController = playerObject.GetComponent<CharacterController>();
            characterController.enabled = false;
            playerObject.transform.SetPositionAndRotation(tform.position, tform.rotation);
            characterController.enabled = true;
        }
        else
        {
            Debug.LogWarning("No empty GameObject found inside the spawned object.");
        }
    }

    

}
